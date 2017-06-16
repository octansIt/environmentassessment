using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Collector;
using EnvironmentAssessment.Common;
using System.IO;

namespace EnvironmentAssessment.Reporter
{
    public class CJSONGenerator : CReportGenerator
    {
        CSite Totals = new CSite("total", null, null, null);
        Dictionary<string, CSite> SiteList = new Dictionary<string, CSite> { };
        Dictionary<string, CSite> ServiceList = new Dictionary<string, CSite> { };
        Dictionary<string, CSite> DatacenterList = new Dictionary<string, CSite> { };
        Dictionary<string, CSite> ClusterList = new Dictionary<string, CSite> { };

        public void Write(CWriter parent, string strJSONFile, List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers)
        { 
            CFunctions.CreateFileIfNotExist(strJSONFile);
            TextWriter jf = new StreamWriter(strJSONFile, false);

            StringBuilder sites = new StringBuilder(0xffff);
            StringBuilder services = new StringBuilder(0xffff);
            StringBuilder datacenters = new StringBuilder(0xffff);
            StringBuilder datastores = new StringBuilder(0xffff);
            StringBuilder clusters = new StringBuilder(0xffff);
            StringBuilder hosts = new StringBuilder(0xffff);
            StringBuilder vms = new StringBuilder(0xffff);

            EnumGroupingInfo(DiscoveredSites, DiscoveredServers);
            //Log.Write("Populating object totals for report output.", Log.Verbosity.Debug);

            int count = 0;
            string prefix = "";
            foreach(CSite cluster in ClusterList.Values)
            {
                count++; if (count > 1) { prefix = ","; }
                clusters.Append(CFunctions.StringReplace(prefix + "\r\n{" + _PrettyPrint("name","datacenter") + ",", cluster.Name, cluster.Location));

                StringBuilder hostinfo = EnumHostInfo(cluster.Name, DiscoveredServers);
                if (hostinfo.Length > 0) { hosts.Append(prefix + hostinfo); }

                StringBuilder vminfo = EnumVMInfo(cluster.Name, DiscoveredServers);
                if (vminfo.Length > 0) { vms.Append(prefix + vminfo); }

                StringBuilder datastoreinfo = EnumDatastoreInfo(cluster.Name, DiscoveredServers);
                if (datastoreinfo.Length > 0) { datastores.Append(prefix + datastoreinfo); }

                clusters.Append(EnumSiteInfo(cluster) + "}");
            }

            count = 0;
            prefix = "";
            foreach (CSite site in SiteList.Values)
            {
                count++; if (count > 1) { prefix = ","; }
                string sitename = site.Name;
                sites.Append(CFunctions.StringReplace(prefix + "\r\n{" + _PrettyPrint("name", "host_cpu") + ",", sitename, site.Details.HostSockets.ToString()));
                string subnets = null; if (site.Subnets != null) { subnets = String.Join(";", site.Subnets); }
                sites.Append(CFunctions.StringReplace(_PrettyPrint("subnets") + "," + EnumSiteInfo(site) + "}", subnets));
            }

            count = 0;
            prefix = "";
            foreach (CSite service in ServiceList.Values)
            {
                count++; if (count > 1) { prefix = ","; }
                services.Append(CFunctions.StringReplace(prefix + "\r\n{" + _PrettyPrint("name") + ",", service.Name));
                services.Append(CFunctions.StringReplace(EnumSiteInfo(service) + "}"));
            }
            
            count = 0;
            prefix = "";
            foreach (CSite datacenter in DatacenterList.Values)
            {
                int clustercount = 0;
                foreach(CSite cluster in ClusterList.Values) { if (datacenter.Name == cluster.Location) { clustercount += 1; } }
                count++; if (count > 1) { prefix = ","; }
                datacenters.Append(CFunctions.StringReplace(prefix + "\r\n{" + _PrettyPrint("name", "parent", "cluster_count") + ",", datacenter.Name, datacenter.Location, clustercount.ToString()));
                datacenters.Append(CFunctions.StringReplace(EnumSiteInfo(datacenter) + "}"));
            }
            
            jf.Write("{\r\n");
            jf.Write("\"sites\":[");
            jf.Write(sites);
            jf.Write("],\r\n\"services\":[");
            jf.Write(services);
            jf.Write("],\r\n\"datacenters\":[");
            jf.Write(datacenters);
            jf.Write("],\r\n\"clusters\":[");
            jf.Write(clusters);
            jf.Write("],\r\n\"datastores\":[");
            jf.Write(datastores);
            jf.Write("],\r\n\"hosts\":[");
            jf.Write(hosts);
            jf.Write("],\r\n\"vms\":[");
            jf.Write(vms);
            jf.Write("]");
            jf.Write("\r\n}");
            jf.Close();

            parent.Progress.Status = new CTaskInfo.State(CTaskInfo.State.Success);
            parent.Completed = true;
        }

        private string EnumSiteInfo(CSite site)
        {
            string result = null;
            string source = _PrettyPrint("ds_disk_usage", "ds_count", "vm_disk_usage", "vm_count", "host_count", "guest_oses", "host_oses");
            string ds_diskusage = site.Details.DatastoreUsage[1].ToString("0") + "/" + site.Details.DatastoreUsage[0].ToString("0");
            string vm_diskusage = site.Details.VMUsageReported[1].ToString("0") + "/" + site.Details.VMUsageReported[0].ToString("0");
            if (COptions.Preciseness == COptions.Precision.High) {  vm_diskusage = site.Details.VMUsageActual[1].ToString("0") + "/" + site.Details.VMUsageActual[0].ToString("0"); }
            string host_os = null; if (site.Details.HostOperatingSystems != null) { host_os = String.Join(";", site.Details.HostOperatingSystems); }
            string guest_os = null; if (site.Details.HostOperatingSystems != null) { guest_os = String.Join(";", site.Details.GuestOperatingSystems); }
            result = CFunctions.StringReplace(source, ds_diskusage, site.Details.Datastores.ToString(), vm_diskusage, site.Details.VMs.ToString(), site.Details.Hosts.ToString(), guest_os, host_os);
            return result;
        }

        private StringBuilder EnumHostInfo(string ClusterName, List<IDiscoveredObject> DiscoveredServers)
        {
            string dbgstr = "Populating host information ";
            if (ClusterName == "") { dbgstr += "for objects without cluster."; }
            else { dbgstr += "organized by cluster " + ClusterName + "."; }
            
            StringBuilder result = new StringBuilder(0xfff);
            foreach (CService server in DiscoveredServers)
            {
                int count = 0;

                foreach (CQuery query in server.Session.Queries)
                {
                    if (query.Type == CQuery.Types.Hosts)
                    {
                        string prefix = ""; 
                        
                        for (int i = 0; i < query.Result.Count; i++)
                        {
                            CServiceConfig sc = query.Result[i];

                            if (sc.Cluster == ClusterName)
                            {
                                count++; if (count > 1) { prefix = ","; }
                                
                                string source = prefix + PrettyPrint("site","cluster","name","ip_address","os","cpu","ram","datastores", "vms", "status", "power_state");
                                string site = CSite.ToStringNz(sc.Site);
                                string parent = server.Name;
                                string cluster = sc.Cluster;
                                string name = sc.Name;
                                string ip = CNetwork.IPToStringNz(sc.IP);
                                string os = sc.OS;
                                string cpu = sc.CPUSockets + " (" + sc.CPUCores + ")";
                                string ram = sc.RAM.ToString("0");
                                string vms = sc.Children[0];
                                string datastores = sc.Children[1];
                                string status = sc.State.ConfigState;
                                string power_state = sc.State.PowerState.ToLower();
                                string host = CFunctions.StringReplace(source, site, cluster, name, ip, os, cpu, ram, datastores, vms, status, power_state);
                                result.AppendLine(host);

                                RollupTotals(query.Type, server, sc);   
                            }
                        }
                    }
                }
            }
            return result;
        }

        private StringBuilder EnumDatastoreInfo(string ClusterName, List<IDiscoveredObject> DiscoveredServers)
        {
            string dbgstr = "Populating datastore information ";
            if (ClusterName == "") { dbgstr += "for objects without cluster."; }
            else { dbgstr += "organized by cluster " + ClusterName + "."; }
            
            StringBuilder result = new StringBuilder(0xfff);
            foreach (CService server in DiscoveredServers)
            {
                int count = 0;

                foreach (CQuery query in server.Session.Queries)
                {
                    if (query.Type == CQuery.Types.Datastores)
                    {
                        string prefix = ""; 

                        for (int i = 0; i < query.Result[0].Disks.Count; i++)
                        {
                            CStorageConfig sc = query.Result[0].Disks[i];
                            if (sc.Cluster == ClusterName)
                            {
                                count++; if (count > 1) { prefix = ","; }
                                    
                                string source = prefix + PrettyPrint("site","parent","name","vendor","type","disk_usage", "status");
                                string site = CSite.ToStringNz(sc.Site);
                                //string parent = server.Name;
                                string name = sc.Name;
                                string vendor = sc.Vendor;
                                string type = sc.Type;
                                string usage = sc.Used + "/" + sc.Allocated;
                                string status = sc.State.ConfigState;
                                string parent = null;
                                if (sc.Owner != null)
                                {
                                    if (sc.Owner.Count > 1) { parent = ClusterName; }
                                    else { parent = sc.Owner[0]; }
                                }


                                // vm count
                                result.AppendLine(CFunctions.StringReplace(source, site, parent, name, vendor, type, usage, status));

                                RollupTotals(query.Type, server, sc);
                            }

                        }
                    }
                }
            }
            return result;
        }

        private StringBuilder EnumVMInfo(string ClusterName, List<IDiscoveredObject> DiscoveredServers)
        {
            string dbgstr = "Populating guest information ";
            if (ClusterName == "") { dbgstr += "for objects without cluster."; }
            else { dbgstr += "organized by cluster " + ClusterName + "."; }
            
            StringBuilder result = new StringBuilder(0xfff);
            foreach (CService server in DiscoveredServers)
            {
                int count = 0;

                foreach (CQuery query in server.Session.Queries)
                {
                    if (query.Type == CQuery.Types.VMs)
                    {
                        string prefix = ""; 

                        for (int i = 0; i < query.Result.Count; i++)
                        {
                            CServiceConfig sc = query.Result[i];
                            if (sc.Cluster == ClusterName)
                            {
                                count++; if (count > 1) { prefix = ","; }

                                string source = prefix + PrettyPrint("site", "host", "name", "ip_address", "os", "cpu", "ram", "disk_usage", "status", "power_state");
                                string site = CSite.ToStringNz(sc.Site);
                                string parent = server.Name;
                                string name = sc.Name;
                                string ip = CNetwork.IPToStringNz(sc.IP);
                                string os = sc.OS;
                                string cpu = sc.CPUSockets + " (" + sc.CPUCores + ")";
                                string ram = sc.RAM.ToString("0");
                                string reportedusage = sc.DiskUsageReported[1].ToString("0") + "/" + sc.DiskUsageReported[0].ToString("0");
                                string actualusage = sc.DiskUsageActual[1].ToString("0") + "/" + sc.DiskUsageActual[0].ToString("0");
                                string usage = "";
                                string status = sc.State.ConfigState;
                                string power_state = sc.State.PowerState.ToLower();
                                if (COptions.Preciseness == COptions.Precision.High) { usage = actualusage; }
                                else { usage = reportedusage; }
                                string host = null;
                                if (sc.Owner != null) { host = sc.Owner[0]; }

                                result.AppendLine(CFunctions.StringReplace(source, site, host, name, ip, os, cpu, ram, usage, status, power_state));

                                RollupTotals(query.Type, server, sc);
                            }
                        }
                    }
                }
            }
            return result;
        }

        internal void RollupTotals(CQuery.Types querytype, CService server, object obj)
        {
            string dbgstr = "  ";
            string Site = "";
            string Cluster = "";
            string Datacenter = "";
            if (obj.GetType().FullName.Contains("CServiceConfig")) { CServiceConfig sc = (CServiceConfig)obj; dbgstr += sc.Name; Site = CSite.ToStringNz(sc.Site); Cluster = sc.Cluster; Datacenter = sc.Datacenter; }
            else if (obj.GetType().FullName.Contains("CStorageConfig")) { CStorageConfig sc = (CStorageConfig)obj; dbgstr += sc.Name; Site = CSite.ToStringNz(sc.Site); Cluster = sc.Cluster; Datacenter = sc.Datacenter; }

            dbgstr += CFunctions.StringReplace(" ({0}, {1}, {2}, {3})", Site, server.Name, Datacenter, Cluster);
            
            // individual cluster totals
            base.RollupTotals(querytype, ClusterList[Cluster], obj);

            // individual datacenter totals
            base.RollupTotals(querytype, DatacenterList[Datacenter], obj);

            // individual service totals
            base.RollupTotals(querytype, ServiceList[server.Name], obj);

            // individual site totals
            base.RollupTotals(querytype, SiteList[Site], obj);

            // overall site totals
            base.RollupTotals(querytype, Totals, obj);
        }
        
        private void EnumGroupingInfo(List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers)
        {
            foreach (CSite site in DiscoveredSites) { SiteList.Add(site.Name, site); }

            foreach (CService server in DiscoveredServers)
            {
                if (!ServiceList.ContainsKey(server.Name)) { ServiceList.Add(server.Name, new CSite(server.Name, "", "", "")); }
                foreach (CQuery query in server.Session.Queries)
                {
                    if (query.Type == CQuery.Types.Hosts)
                    {
                        for (int i = 0; i < query.Result.Count; i++)
                        {
                            CServiceConfig sc = query.Result[i];
                            if (!DatacenterList.ContainsKey(sc.Datacenter)) {
                                DatacenterList.Add(sc.Datacenter, new CSite(sc.Datacenter, "", server.Name, ""));
                            }
                            if (!ClusterList.ContainsKey(sc.Cluster)) {
                                ClusterList.Add(sc.Cluster, new CSite(sc.Cluster, "", sc.Datacenter, ""));
                            }
                        }
                    }
                }
            }

            if (!SiteList.ContainsKey("")) { SiteList.Add("", new CSite("", "", "", "")); } // blank catch all site
            if (!DatacenterList.ContainsKey("")) { DatacenterList.Add("", new CSite("", "", "", "")); } // blank catch all datacenter
            if (!ClusterList.ContainsKey("")) { ClusterList.Add("", new CSite("", "", "", "")); } // blank catch all cluster

        }

        public static string _PrettyPrint(params string[] list)
        {
            string result = "";
            for (int i = 0; i < list.Count(); i++)
            {
                result += "\"" + list[i] + "\":\"{" + i + "}\"";
                if (i < list.Count() -1) { result += ", "; }
            }
            return result;
        }
        public static string PrettyPrint(params string[] list)
        {
            string result = "{ ";
            result += _PrettyPrint(list);
            result += " }";
            return result;
        }
    }
}

static class Extensions
{
    public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
    {
        foreach (var i in ie)
        {
            action(i);
        }
    }
}
