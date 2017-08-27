using EnvironmentAssessment.Collector;
using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Database
{
    public class CDatabaseExporter
    {
        CDatabaseConnection _DBConn;
        Dictionary<string, CDiscoveredConfig> DiscoveredGroups;
        List<CSite> DiscoveredSites;
        List<string> ExportedEntries;

        public void Export(CSession parent, ref CDatabaseConnection conn, List<IDiscoveredObject> sites, List<IDiscoveredObject> DiscoveredServers)
        {
            _DBConn = conn;

            IEnumerable<CSite> _discoveredsites = sites.OfType<CSite>();
            DiscoveredSites = new List<CSite> { };
            DiscoveredSites.AddRange(_discoveredsites);
            DiscoveredGroups = new Dictionary<string, CDiscoveredConfig> { };
            ExportedEntries = new List<string> { };

            foreach (CService server in DiscoveredServers)
            {
                foreach (CQuery query in server.Session.Queries)
                {
                    for (int i = 0; i < query.Result.Count; i++)
                    {
                        ExportDiscoveredConfig(query.Result[i], server, true);
                    }
                }
                foreach (CDiscoveredConfig group in DiscoveredGroups.Values)
                {
                    ExportDiscoveredConfig(group);
                }
            }

            _DBConn.Close();
            _DBConn.Dispose();
            parent.Progress.Status = new CTaskInfo.State(CTaskInfo.State.Success);
            parent.Completed = true;
        }

        private void AddGroupingInfo(CService server, CDiscoveredConfig oc)
        {
            if (server.Type == CServiceType.VCenterServer)
            {
                _AddGroupingInfo(server, server.Name, CDiscoveredTypes.VCenterServer, server.Id, server.Id);
                string dc = oc.Attributes.Get(CAttributeType.Datacenter).ToStringNz();
                string cl = oc.Attributes.Get(CAttributeType.Cluster).ToStringNz();
                string dcid = _AddGroupingInfo(server, dc, CDiscoveredTypes.VIDatacenter, server.Id);
                string clid = _AddGroupingInfo(server, cl, CDiscoveredTypes.VICluster, dcid);
            }
            if (server.Type == CServiceType.HYVServer)
            {
                string cl = oc.Attributes.Get(CAttributeType.Cluster).ToStringNz();
                if (cl.Length > 0) { string clid = _AddGroupingInfo(server, cl, CDiscoveredTypes.HVCluster, "", ""); }
                else
                {
                    string hostid = _AddGroupingInfo(server, server.Name, CDiscoveredTypes.HVHost, server.Id, server.Id);
                }
            }
            if (server.Type == CServiceType.ESXServer)
            {
                string hostid = _AddGroupingInfo(server, server.Name, CDiscoveredTypes.VIHost, server.Id, server.Id);
            }
            _AddGroupingInfo(server, oc.Site.ToStringNz(), CDiscoveredTypes.Site, server.Id);
        }

        private CDiscoveredConfig UpdateGroupingInfo(CService server, CDiscoveredConfig oc)
        {
            foreach (CDiscoveredConfig group in DiscoveredGroups.Values)
            {
                bool match = false;
                match = match || (group.Type == CDiscoveredTypes.VCenterServer && group.Name == server.Name);
                match = match || (group.Type == CDiscoveredTypes.SCVMMServer && group.Name == server.Name);
                match = match || (group.Type == CDiscoveredTypes.Site && group.Name == oc.Site.ToStringNz());
                match = match || (group.Type == CDiscoveredTypes.VIDatacenter && group.Name == oc.Attributes.Get(CAttributeType.Datacenter).ToStringNz());
                match = match || (group.Type == CDiscoveredTypes.VICluster && group.Name == oc.Attributes.Get(CAttributeType.Cluster).ToStringNz()) ;
                match = match || (group.Type == CDiscoveredTypes.HVCluster && group.Name == oc.Attributes.Get(CAttributeType.Cluster).ToStringNz());
                match = match || (group.Type == CDiscoveredTypes.VIHost && oc.Owner.Contains(group.Id));
                match = match || (group.Type == CDiscoveredTypes.HVHost && oc.Owner.Contains(group.Id));
                if (match)
                {
                    oc = _UpdateGroupingInfo(group, oc);
                }
            }
            return oc;
        }

        public string _AddGroupingInfo(CService server, string name, int type, string parent, string id = "")
        {
            if (!DiscoveredGroups.ContainsKey(name))
            {
                if (id != null && id == parent) { parent = ""; } // object = parent: so parent may as well be empty
                DiscoveredGroups.Add(name, new CDiscoveredConfig() { Name = name, Type = type, Owner = new List<string> { parent } });
                if (id != null && id != "") { DiscoveredGroups[name].Id = id; } // if id is specified specifically set this for the group
                if (DiscoveredGroups[name].Attributes == null) { DiscoveredGroups[name].Attributes = new CDiscoveredAttributes(); }
                if (DiscoveredGroups[name].Metrics == null) { DiscoveredGroups[name].Metrics = new CDiscoveredMetrics(); }
                if (type == CDiscoveredTypes.Site)
                {
                    CSite obj = DiscoveredSites.Find(x => x.Name.Equals(name));
                    if (obj != null)
                    {
                        DiscoveredGroups[name].Attributes.Set(CAttributeType.Details, obj.Description.ToStringNz());
                        DiscoveredGroups[name].Attributes.Set(CAttributeType.Path, obj.Path.ToStringNz());
                        DiscoveredGroups[name].Attributes.Set(CAttributeType.Location, obj.Location.ToStringNz());
                        DiscoveredGroups[name].Attributes.Set(CAttributeType.Subnets, CFunctions.StringJoin(";",obj.Subnets));
                    }
                }
                else if ((type == CDiscoveredTypes.VICluster))
                {
                    if (DiscoveredGroups.ContainsKey(server.Name)) {
                        DiscoveredGroups[server.Name].Metrics.Increment(CMetricType.ClCount, 1);
                    }
                }
                else if ((type == CDiscoveredTypes.HVCluster))
                {
                    DiscoveredGroups[name].Metrics.Increment(CMetricType.ClCount, 1);
                }
                else if ((type == CDiscoveredTypes.VIDatacenter) || (type == CDiscoveredTypes.HVDatacenter))
                {
                    if (DiscoveredGroups.ContainsKey(server.Name)) {
                        DiscoveredGroups[server.Name].Metrics.Increment(CMetricType.DcCount, 1);
                    }
                }
                return DiscoveredGroups[name].Id;
            }
            return null;
        }

        public CDiscoveredConfig _UpdateObjectGroupingInfo(CDiscoveredConfig oc)
        {
            if ((oc.Type == CDiscoveredTypes.VIHost) || (oc.Type == CDiscoveredTypes.HVHost))
            {
                CDiscoveredConfig cluster = null;
                CDiscoveredConfig datacenter = null;
                string clusterstr = oc.Attributes.Get(CAttributeType.Cluster);
                string datacenterstr = oc.Attributes.Get(CAttributeType.Datacenter);
                
                if ((clusterstr != null) && (DiscoveredGroups.TryGetValue(clusterstr, out cluster)))
                {
                    oc.Owner = new List<string> { cluster.Id };
                }
                else if ((datacenterstr != null) && (DiscoveredGroups.TryGetValue(datacenterstr, out datacenter)))
                {
                    oc.Owner = new List<string> { datacenter.Id };
                }
                
            }
            return oc;
        }

        public CDiscoveredConfig _UpdateGroupingInfo(CDiscoveredConfig group, CDiscoveredConfig oc)
        {
            if ((oc.Type == CDiscoveredTypes.VIHost) || (oc.Type == CDiscoveredTypes.HVHost))
            {
                group.Metrics.Increment(CMetricType.HostCpu, CMetricSubtype.Sockets, oc);
                group.Metrics.Increment(CMetricType.HostCpu, CMetricSubtype.Cores, oc);
                group.Metrics.Increment(CMetricType.HostMem, CMetricSubtype.Allocated, oc);
                group.Metrics.Increment(CMetricType.HostCount, 1);
            }
            else if ((oc.Type == CDiscoveredTypes.VIVM) || (oc.Type == CDiscoveredTypes.HVVM))
            {
                group.Metrics.Increment(CMetricType.VmCpu, CMetricSubtype.Sockets, oc);
                group.Metrics.Increment(CMetricType.VmCpu, CMetricSubtype.Cores, oc);
                group.Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Allocated, oc);
                group.Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Used, oc);
                group.Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Unshared, oc);
                group.Metrics.Increment(CMetricType.VmMem, CMetricSubtype.Allocated, oc);
                group.Metrics.Increment(CMetricType.VmCount, 1);
            }
            else if ((oc.Type == CDiscoveredTypes.VIDatastore) || (oc.Type == CDiscoveredTypes.HVDatastore))
            {
                group.Metrics.Increment(CMetricType.DsDisk, CMetricSubtype.Allocated, oc);
                group.Metrics.Increment(CMetricType.DsDisk, CMetricSubtype.Used, oc);
                group.Metrics.Increment(CMetricType.DsCount, 1);
            }

            oc = _UpdateObjectGroupingInfo(oc);

            return oc;
        }

        public void ExportDiscoveredConfig(CDiscoveredConfig oc, CService server = null, bool rolluptotals = false)
        {
            if (oc.Attributes != null && oc.Name.Length > 0)
            {
                if (server != null && rolluptotals)
                {
                    // create grouping objects
                    AddGroupingInfo(server, oc);

                    // rollup totals by group and repair object parent properties
                    oc = UpdateGroupingInfo(server, oc);
                }
                CDatabaseEntry entry = new CDatabaseEntry();
                entry.Id = oc.Id.ToString();
                entry.Reference = oc.Attributes.Get(CAttributeType.Reference);
                entry.Created = oc.Attributes.Get(CAttributeType.Created);
                entry.Accessed = oc.Attributes.Get(CAttributeType.Accessed);
                entry.Name = CFunctions.EscapeJson(oc.Name);
                entry.Type = oc.Type.ToString();
                entry.Parent = CFunctions.StringJoin(";", oc.Owner);
                entry.Attributes = oc.Serialize(CDiscoveredConfig.SerializeAsShortJson);
                if (!ExportedEntries.Contains(entry.Id))
                {
                    _DBConn.AddEntry(entry);
                    ExportedEntries.Add(entry.Id);
                }
                else
                {
                    _DBConn.UpdateEntry(entry);
                }
            }
            if (oc.ChildObjects != null)
            {
                foreach (CDiscoveredConfig obj in oc.ChildObjects) { ExportDiscoveredConfig(obj, server, rolluptotals); }
            }
        }
    }
}
