using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using EnvironmentAssessment.Common.HvApi;

namespace EnvironmentAssessment.Collector
{
    internal class HviSession : ISession
    {
        internal string SessionID;

        HviClient HVClient = null;
        HostSystem HVSession = null;

        internal List<CSite> _SiteInfo = new List<CSite> { };

        private Dictionary<string, string> ObjectUidCache;

        public HviSession(ref CService _Server)
        {
            Server = _Server;
        }

        internal List<CDiscoveredConfig> GetHosts(int queryid)
        {
            List<CDiscoveredConfig> HostsFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> hosts = null;

            // dont continue if not logged in
            if (HVClient == null) { return HostsFound; }

            try { Log.Write("[HvApi] Querying hosts associated with: " + Server.Name.ToUpper()); hosts = HVClient.FindEntityViews(typeof(HostSystem)); }
            catch (Exception ex) { Log.Write("Error: Cannot query host information. Details: " + ex.TargetSite + ex.Message); }

            _SiteInfo = Server.Session.Queries[queryid].Sites;

            if (hosts != null)
            {
                Log.Write(CFunctions.StringReplace("Found hosts ({0}) associated with {1}", hosts.Count.ToString(), Server.Name.ToUpper()));
                foreach (HostSystem host in hosts)
                {
                    string cluster = ""; 
                    if (HVClient.HostType == HvHostType.Cluster) { cluster = HVClient._ClusterName; }

                    CDiscoveredMetrics hostmetrics = new CDiscoveredMetrics();
                    hostmetrics.Set(CMetricType.HostCpu, CMetricSubtype.Sockets, host.Hardware.CpuInfo.NumCpuPackages);
                    hostmetrics.Set(CMetricType.HostCpu, CMetricSubtype.Cores, host.Hardware.CpuInfo.NumCpuCores);
                    hostmetrics.Set(CMetricType.HostMem, CMetricSubtype.Allocated, CFunctions.ConvertDataUnit(host.Hardware.MemorySize, CDataUnitType.Byte, CDataUnitType.MiB));
                    hostmetrics.Set(CMetricType.VmCount, CMetricSubtype.None, host.Vm.Count());
                    hostmetrics.Set(CMetricType.DsCount, CMetricSubtype.None, host.Datastore.Count());

                    CDiscoveredAttributes hostattribs = new CDiscoveredAttributes();
                    hostattribs.Set(CAttributeType.Reference, "HostSystem-" + host.Id.ToLower());
                    hostattribs.Set(CAttributeType.IP, host.IP.ToString());
                    hostattribs.Set(CAttributeType.OS, host.OS);
                    hostattribs.Set(CAttributeType.Cluster, cluster);
                    hostattribs.Set(CAttributeType.HardwareVersion, (host.Hardware.SystemInfo.Vendor + " " + host.Hardware.SystemInfo.Model).Replace(",", String.Empty));
                    hostattribs.Set(CAttributeType.PowerState, "poweredOn"); // silly but we will not get any data from powered off hosts 
                    //hostattribs.Merge(GetObjectState(host))

                    CDiscoveredConfig hostinfo = new CDiscoveredConfig()
                    {
                        Type = new CDiscoveredTypes(CDiscoveredTypes.HVHost),
                        Site = CSite.Resolve(host.IP, _SiteInfo),
                        Name = host.Name.ToString(),
                        Metrics = hostmetrics,
                        Attributes = hostattribs,
                        Owner = new List<string> { Server.Id }
                    };

                    if ((hosts.Count == 1) && (HVClient.HostType == HvHostType.Standalone)) { hostinfo.Id = Server.Id; }
                    StoreObjectUid(hostinfo.Name, hostinfo.Id);

                    Log.Write(hostinfo.ToString(), Log.Verbosity.Debug);

                    HostsFound.Add(hostinfo);
                }
                HostsFound = HostsFound.OrderBy(o => o.Name).ToList();
            }
 
            return HostsFound;
        }

        internal List<CDiscoveredConfig> GetDatastores(int queryid)
        {
            List<CDiscoveredConfig> DatastoresFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> datastores = null;

            // dont continue if not logged in
            if (HVClient == null) { return DatastoresFound; }

            try { Log.Write("[HvApi] Querying datastores associated with: " + Server.Name.ToUpper()); datastores = HVClient.FindEntityViews(typeof(Datastore)); }
            catch (Exception ex) { Log.Write("Error: Cannot query datastore information. Details: " + ex.TargetSite + ex.Message); }

            _SiteInfo = Server.Session.Queries[queryid].Sites;

            if (datastores != null)
            {
                // iterate through vms and get general information
                Log.Write(CFunctions.StringReplace("Found datastores ({0}) associated with {1}", datastores.Count.ToString(), Server.Name.ToUpper()));

                foreach (EntityViewBase tmp in datastores)
                {
                    Datastore ds = (Datastore)tmp;

                    if (ds.Name != null)
                    {
                        long storagealloc = CFunctions.ConvertDataUnit(ds.Capacity, CDataUnitType.Byte, CDataUnitType.MiB);
                        long storageused = CFunctions.ConvertDataUnit(ds.Capacity - ds.FreeSpace, CDataUnitType.Byte, CDataUnitType.MiB);

                        List<string> owner = new List<string> { };
                        foreach (string parent in ds.Host.Split(';')) {
                            owner.Add(RetrieveObjectUid(parent));
                        }

                        CDiscoveredMetrics dsmetric = new CDiscoveredMetrics();
                        dsmetric.Set(CMetricType.DsDisk, CMetricSubtype.Allocated, storagealloc);
                        dsmetric.Set(CMetricType.DsDisk, CMetricSubtype.Used, storageused);

                        CDiscoveredAttributes dsattrib = new CDiscoveredAttributes();

                        string id = ds.ID.Split('{')[1].Split('}')[0];
                        dsattrib.Set(CAttributeType.Reference, "Datastore-" + id);
                        dsattrib.Set(CAttributeType.Format, ds.FileSystem);
                        dsattrib.Set(CAttributeType.Vendor, ds.Vendor);
                        dsattrib.Set(CAttributeType.Model, ds.Model);
                        dsattrib.Set(CAttributeType.Mode, ds.AccessMode);
                        dsattrib.Set(CAttributeType.Cluster, ds.Cluster);

                        bool islocal = true;
                        if ((ds.AccessMode.ToLower().Contains("iscsi")) || (ds.AccessMode.ToLower().Contains("fibre"))) { islocal = false; }
                        dsattrib.Set(CAttributeType.Local, islocal.ToString());

                        CDiscoveredConfig dsinfo = new CDiscoveredConfig();
                        dsinfo.Type = new CDiscoveredTypes(CDiscoveredTypes.HVDatastore);
                        dsinfo.Name = ds.Name;
                        dsinfo.Metrics = dsmetric;
                        dsinfo.Attributes = dsattrib;
                        dsinfo.Owner = owner;

                        StoreObjectUid(dsinfo.Attributes.Get(CAttributeType.Reference), dsinfo.Id);

                        Log.Write(dsinfo.ToString(), Log.Verbosity.Debug);

                        DatastoresFound.Add(dsinfo);
                    }
                }
                DatastoresFound = DatastoresFound.OrderBy(o => o.Name).ToList();
            }
            return DatastoresFound;
        }

        internal List<CDiscoveredConfig> GetVms(int queryid)
        {
            List<CDiscoveredConfig> VMsFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> vms = null;

            // dont continue if not logged in
            if (HVClient == null) { return VMsFound; }

            try { Log.Write("[HvApi] Querying virtual machines associated with: " + Server.Name.ToUpper()); vms = HVClient.FindEntityViews(typeof(VirtualMachine)); }
            catch (Exception ex) { Log.Write("Error: Cannot query virtual machine information. Details: " + ex.TargetSite + ex.Message); }

            _SiteInfo = Server.Session.Queries[queryid].Sites;

            if (vms != null)
            {
                // iterate through vms and get general information
                Log.Write(CFunctions.StringReplace("Found virtual machines ({0}) associated with {1}", vms.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in vms)
                {
                    VirtualMachine vm = (VirtualMachine)tmp;

                    if (vm.Name != null)
                    {
                        long storagealloc = CFunctions.ConvertDataUnit(vm.Storage.Allocated, CDataUnitType.Byte, CDataUnitType.MiB);
                        long storageused = CFunctions.ConvertDataUnit(vm.Storage.Used, CDataUnitType.Byte, CDataUnitType.MiB);
                        //double storageunshared = CFunctions.ConvertDataUnit(vm.Storage.Unshared, CDataUnitType.Byte, CDataUnitType.MiB);

                        string owner = RetrieveObjectUid(vm.Host);

                        CDiscoveredMetrics guestusage = new CDiscoveredMetrics();
                        guestusage.Set(CMetricType.VmDisk, CMetricSubtype.Allocated, vm.Storage.Allocated);
                        guestusage.Set(CMetricType.VmDisk, CMetricSubtype.Used, vm.Storage.Used);
                        guestusage.Set(CMetricType.VmCpu, CMetricSubtype.Sockets, vm.Hardware.NumCPU);
                        guestusage.Set(CMetricType.VmCpu, CMetricSubtype.Cores, ((int)vm.Hardware.NumCPU * vm.Hardware.NumCoresPerSocket.GetValueOrDefault(1)));
                        guestusage.Set(CMetricType.VmMem, CMetricSubtype.Allocated, vm.Hardware.MemoryMB);
                        guestusage.Set(CMetricType.VmDisk, CMetricSubtype.Allocated, storagealloc);
                        guestusage.Set(CMetricType.VmDisk, CMetricSubtype.Used, storageused);

                        CDiscoveredAttributes guestattribs = new CDiscoveredAttributes();
                        guestattribs.Set(CAttributeType.Reference, "VirtualMachine-" + vm.Id.ToLower());
                        guestattribs.Set(CAttributeType.IP, vm.Guest.IP.ToString());
                        guestattribs.Set(CAttributeType.OS, vm.Guest.OS);
                        guestattribs.Set(CAttributeType.HardwareVersion, vm.Version);
                        guestattribs.Set(CAttributeType.ToolsVersion, vm.Guest.ToolsVersion.ToString());

                        guestattribs.Set(CAttributeType.Cluster, vm.Cluster);

                        //guestattribs.Merge(GetObjectState(vm))
                        string vmPowerState = "poweredOff";
                        if ((VmEnabledState)vm.State == VmEnabledState.Enabled) {
                            vmPowerState = "poweredOn";
                        } else if (((VmEnabledState)vm.State == VmEnabledState.Paused) || ((VmEnabledState)vm.State == VmEnabledState.Pausing) || ((VmEnabledState)vm.State == VmEnabledState.Suspended)) {
                            vmPowerState = "suspended";
                        }
                        guestattribs.Set(CAttributeType.PowerState, vmPowerState);
                        CDiscoveredConfig guestinfo = new CDiscoveredConfig
                        {
                            Type = new CDiscoveredTypes(CDiscoveredTypes.HVVM),
                            Site = CSite.Resolve(vm.Guest.IP, _SiteInfo),
                            Name = vm.Name.ToString(),
                            Metrics = guestusage,
                            Attributes = guestattribs,
                            Owner = new List<string> { owner }
                        };

                        StoreObjectUid(guestinfo.Attributes.Get(CAttributeType.Reference), guestinfo.Id);
                        guestinfo.ChildObjects = GetVmDisks(queryid, vm);

                        Log.Write(guestinfo.ToString(), Log.Verbosity.Debug);

                        VMsFound.Add(guestinfo);
                    }
                }

                VMsFound = VMsFound.OrderBy(o => o.Name).ToList(); // sort alphabally

                // get additional details for thin vmdk files
                //VMsFound = UpdateVIVMDiskDatastoreInfo(queryid, VMsFound);
            }

            return VMsFound;
        }

        private List<CDiscoveredConfig> GetVmDisks(int queryid, VirtualMachine vm)
        {
            List<CDiscoveredConfig> DisksFound = new List<CDiscoveredConfig> { };

            string parent = RetrieveObjectUid("VirtualMachine-" + vm.Id.ToLower());

            foreach (VirtualDisk disk in vm.Disks)
            {
                CDiscoveredMetrics diskusage = new CDiscoveredMetrics();
                diskusage.Set(CMetricType.VmDisk, CMetricSubtype.Allocated, disk.Allocated);
                diskusage.Set(CMetricType.VmDisk, CMetricSubtype.Used, disk.Used);
                CDiscoveredAttributes diskattribs = new CDiscoveredAttributes();
                diskattribs.Set(CAttributeType.Path, disk.Path);
                string id = disk.Datastore.ToLower().Split('{')[1].Split('}')[0];
                diskattribs.Set(CAttributeType.Reference, "Datastore-" + id);
                bool thin = false;
                if (disk.Type == VirtualDiskType.Dynamic || disk.Type == VirtualDiskType.Differencing)
                {
                    thin = true;
                }
                diskattribs.Set(CAttributeType.Thin,  thin.ToString());
                diskattribs.Set(CAttributeType.Mode, new VirtualDiskMode(disk.Mode).ToString());
                DisksFound.Add(new CDiscoveredConfig() { Name = disk.Name, Attributes = diskattribs, Metrics = diskusage, Type = CDiscoveredTypes.HVDisk, Owner = new List<string> { parent } });
            }
            return DisksFound;
        }
        
        private void StoreObjectUid(string v, string id)
        {
            if (ObjectUidCache == null) { ObjectUidCache = new Dictionary<string, string> { }; }
            ObjectUidCache.Add(v, id);
        }

        private string RetrieveObjectUid(string reference)
        {
            string result = "";
            ObjectUidCache.TryGetValue(reference, out result);
            return result;
        }

        internal void Disconnect()
        {
            throw new NotImplementedException();
        }

        internal int Connect()
        {

            int result = 0;

            // make session ID equal to latest query id added, mostly for progress tracking purposes
            SessionID = Queries[Queries.Count - 1].Id;

            if (this.Error.Length > 0) // don't run if we experienced errors before
            { Completed = true; result = -1; return result; }

            if (!Connected)
            {
                Error = ""; // clear session error details
                // try seeing if port is accessible
                Error = CNetwork.CheckPortStatus(Server.IP, HviClient.DefaultPort);

                if (Error.Length == 0)
                {
                    HVClient = new HviClient();
                    if (Server.UserName == Environment.UserDomainName + "\\" + Environment.UserName) { HVSession = HVClient.LoginWithCurrentCredentials(this); }
                    else { HVSession = HVClient.Login(this); } // otherwise use username and password
                    if (HVSession != null) { if (HVSession.LoginTime != null) { Server.Name = HVClient.Name; Server.Version = HVSession.Version + " (" + HVSession.Build + ")"; Connected = true; result = 0; } }
                    else { Completed = true; result = -1; }
                }
            }
            return result;
        }
    }
}
