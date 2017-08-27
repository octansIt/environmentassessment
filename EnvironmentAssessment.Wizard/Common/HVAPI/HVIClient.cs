using System;
using System.Management;
using EnvironmentAssessment.Collector;
using System.Collections.Generic;
using System.Xml;

namespace EnvironmentAssessment.Common.HvApi
{
    public static class HvWmiReturnCode
    {
        public const UInt32 Completed = 0;
        public const UInt32 Started = 4096;
        public const UInt32 Failed = 32768;
        public const UInt32 AccessDenied = 32769;
        public const UInt32 NotSupported = 32770;
        public const UInt32 Unknown = 32771;
        public const UInt32 Timeout = 32772;
        public const UInt32 InvalidParameter = 32773;
        public const UInt32 SystemInUse = 32774;
        public const UInt32 InvalidState = 32775;
        public const UInt32 IncorrectDataType = 32776;
        public const UInt32 SystemNotAvailable = 32777;
        public const UInt32 OutofMemory = 32778;
        public static string ToString(UInt32 value)
        {
            string result = "Unknown return code";
            switch (value)
            {
                case Completed: result = "Completed"; break;
                case Started: result = "Started"; break;
                case Failed: result = "Failed"; break;
                case AccessDenied: result = "AccessDenied"; break;
                case NotSupported: result = "NotSupported"; break;
                case Unknown: result = "Unknown"; break;
                case Timeout: result = "Timeout"; break;
                case InvalidParameter: result = "InvalidParameter"; break;
                case SystemInUse: result = "SystemInUse"; break;
                case InvalidState: result = "InvalidState"; break;
                case IncorrectDataType: result = "IncorrectDataType"; break;
                case SystemNotAvailable: result = "SystemNotAvailable"; break;
                case OutofMemory: result = "OutofMemory"; break;
            }
            return result;
        }
    }

    public static class HvWmiJobState
    {
        public const UInt16 New = 2;
        public const UInt16 Starting = 3;
        public const UInt16 Running = 4;
        public const UInt16 Suspended = 5;
        public const UInt16 ShuttingDown = 6;
        public const UInt16 Completed = 7;
        public const UInt16 Terminated = 8;
        public const UInt16 Killed = 9;
        public const UInt16 Exception = 10;
        public const UInt16 Service = 11;
        public static string ToString(UInt16 value)
        {
            string result = "Unknown JobState code";
            switch (value)
            {
                case New: result = "New"; break;
                case Starting: result = "Starting"; break;
                case Running: result = "Running"; break;
                case Suspended: result = "Suspended"; break;
                case ShuttingDown: result = "ShuttingDown"; break;
                case Completed: result = "Completed"; break;
                case Terminated: result = "Terminated"; break;
                case Killed: result = "Killed"; break;
                case Exception: result = "Exception"; break;
                case Service: result = "Service"; break;
            }
            return result;
        }
    }

    public class HvHostType : IDisposable
    {
        private int _type;

        private static string[] Values = { "Standalone", "Cluster" };

        public const int Standalone = 0;
        public const int Cluster = 1;

        public HvHostType(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }
        public HvHostType(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            Values = null;
        }

        public override string ToString()
        {
            return Values[_type];
        }

        public static implicit operator int(HvHostType x)
        {
            int i = x._type;
            return i;
        }
    }

    // simplistic approach for now. when using SCVMM the entire approach will have to change. 
    class HviClient : IClient
    {
        internal const ushort DefaultPort = 135;
        internal string _version = null;
        internal string _build = null;
        internal string _logintime = null;
        internal ConnectionOptions _connectionOptions;
        internal string _ClusterName = null;
        internal string _DnsSuffix = null;

        internal string ClusterName { get { return _ClusterName + _DnsSuffix;  } }

        Dictionary<string, HostSystem> _HVHosts = null;
        internal object _HVHostsLock = new Object();

        internal HvHostType HostType = new HvHostType(HvHostType.Standalone);

        internal object _VMMemoryCacheLock = new Object();
        internal Dictionary<string, long> VMMemoryCache = new Dictionary<string, long> { };

        internal object _VMSettingsCacheLock = new Object();
        internal Dictionary<string, VmSettings> VMSettingsCache = new Dictionary<string, VmSettings> { };

        internal object _VMCpuCacheLock = new Object();
        internal Dictionary<string, string> VMCpuCache = new Dictionary<string, string> { };

        internal object _VMDiskCacheLock = new Object();
        internal Dictionary<string, List<VirtualDisk>> VMDiskCache = new Dictionary<string, List<VirtualDisk>> {};

        internal object _DatastoreDiskCacheLock = new Object();
        internal Dictionary<string, Datastore> DatastoreDiskCache = new Dictionary<string, Datastore> {};
        internal string ServiceUrl { get; private set; }
        public string Name { get; private set; }

        void Connect()
        {

        }

        public HostSystem Login(ISession session)
        {
            _connectionOptions = new ConnectionOptions();
            if (session.Server.UserName.Contains("\\"))
            {
                _connectionOptions.Username = session.Server.UserName.Split('\\')[1];
                _connectionOptions.Authority = "ntlmdomain:" + session.Server.UserName.Split('\\')[0];
                _connectionOptions.Password = session.Server.UserPassword;
                _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                _connectionOptions.EnablePrivileges = true;
                //ManagementNamedValueCollection context = _connectionOptions.Context;
                //context.Add("__ProviderArchitecture", 64);
                //context.Add("__RequiredArchitecture", true);
            }
            else
            {
                _connectionOptions.Username = session.Server.UserName;
                _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
                _connectionOptions.Password = session.Server.UserPassword;
                _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                _connectionOptions.EnablePrivileges = true;
                //ManagementNamedValueCollection context = _connectionOptions.Context;
                //context.Add("__ProviderArchitecture", 64);
                //context.Add("__RequiredArchitecture", true);
            }

            return DoLogin(session);

        }

        public HostSystem LoginWithCurrentCredentials(ISession session)
        {
            _connectionOptions = new ConnectionOptions();
            _connectionOptions.Username = Environment.UserName;
            _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
            _connectionOptions.Password = "";
            _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;

            return DoLogin(session);

        }

        public HostSystem DoLogin(ISession session)
        {
            HostSystem host = new HostSystem(session.Server.Name, _connectionOptions);
            this.ServiceUrl = @"\\" + session.Server.Name.ToLower() + @"\root";
            try
            {
                foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT caption, version FROM Win32_OperatingSystem"))).Get())
                {
                    string osver = r.GetPropertyValue("Caption").ToString();
                    osver = osver.Replace("Microsoft ", "");
                    osver = osver.Replace(" Evaluation", "");
                    host.Version = osver;
                    host.Build = r.GetPropertyValue("Version").ToString();
                }
                if (host.Version != null)
                {
                    host.LoginTime = Common.CFunctions.GetDateTime(1);
                    Log.Write("[HvApi] Logged into '" + this.ServiceUrl + "' at " + (host.LoginTime) + " (" + host.Build + ").");
                }
            }
            catch (Exception ex)
            {
                session.Error = ex.Message;
                Log.Write("[HvApi] Login into '" + this.ServiceUrl + "' failed: " + session.Error);
                return null;
            }

            host.Connected = true;

            // check if host is a member of a cluster
            if (host.CheckRegistryAccess(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", CRegistry.KEY_ENUMERATE_SUB_KEYS))
            {
                HostType = new HvHostType(HvHostType.Cluster);

                // if so find child entries and add those to _HVHosts
                _DnsSuffix = "";
                if (session.Server.Name.IndexOf('.') > 0) { _DnsSuffix = session.Server.Name.Substring(session.Server.Name.IndexOf('.')); }
                _ClusterName = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", "ClusterName");

                List<string> nodes = host.EnumRegistrySubkeys(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes");
                lock (_HVHostsLock)
                {
                    _HVHosts = new Dictionary<string, HostSystem> { };
                    foreach (string n in nodes)
                    {
                        string nodename = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes\" + n, "NodeName") + _DnsSuffix;
                        HostSystem node;
                        if (host.Name.ToLower() == nodename.ToLower()) { node = new HostSystem(nodename, _connectionOptions, true, host.Scopes); } // clone scopes
                        else { node = new HostSystem(nodename, _connectionOptions, true); }
                        _HVHosts.Add(nodename, node);
                    }
                }
                this.Name = this.ClusterName;
            }
            else
            {
                lock (_HVHostsLock)
                {
                    _HVHosts = new Dictionary<string, HostSystem> { };
                    _HVHosts.Add(host.Name, host);
                }
                this.Name = host.Name;
            }

            return host;
        }

        void Disconnect()
        {

        }

        private long GetVmMemoryCached(string id)
        {
            lock (_VMMemoryCacheLock) {
                long result = 0;
                if (VMMemoryCache.TryGetValue(id, out result)) { return result; }
                else
                {
                    foreach (HostSystem host in GetHostCached().Values)
                    {
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT instanceid, virtualquantity FROM Msvm_MemorySettingData WHERE NOT instanceid LIKE '%Definition%'"))).Get())
                        {
                            string _id = ((r.GetPropertyValue("InstanceId").ToString()).Split('\\')[0]).Replace("Microsoft:","");
                            long _val = Convert.ToInt64(r.GetPropertyValue("VirtualQuantity"));
                            if (!VMMemoryCache.ContainsKey(_id)) { VMMemoryCache.Add(_id, _val); }
                        }
                    }
                    if (VMMemoryCache.TryGetValue(id, out result)) { return result; }
                }
                return result;
            }
        }

        private VmSettings GetVmSettingsCached(string id)
        {
            lock (_VMSettingsCacheLock)
            {
                VmSettings result = null;
                if (VMSettingsCache.TryGetValue(id, out result)) { return result; }
                else
                {
                    foreach (HostSystem host in GetHostCached().Values)
                    {
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT * FROM Msvm_VirtualSystemSettingData WHERE NOT instanceid LIKE '%Definition%'"))).Get())
                        {
                            string _id = ((r.GetPropertyValue("InstanceId").ToString()).Split('\\')[0]).Replace("Microsoft:", "");
                            VmSettings settings = new VmSettings();
                            settings.Version = Convert.ToDouble(r.GetPropertyValue("Version"));
                            settings.CreationTime = r.GetPropertyValue("CreationTime").ToString();
                            if (!VMSettingsCache.ContainsKey(_id)) { VMSettingsCache.Add(_id, settings); }
                        }
                    }
                    if (VMSettingsCache.TryGetValue(id, out result)) { return result; }
                }
                return result;
            }
        }

    private int GetVmCpuCached(string vmid)
        {
            lock (_VMCpuCacheLock)
            {
                string processorids = "";
                int result = 0;
                if (VMCpuCache.TryGetValue(vmid, out processorids)) { return processorids.Split(',').Length; }
                else
                {
                    foreach (HostSystem host in GetHostCached().Values)
                    {
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT systemname, deviceid FROM Msvm_Processor WHERE role='Virtual Processor'"))).Get())
                        {
                            string _id = (r.GetPropertyValue("SystemName").ToString());
                            string _val = ((r.GetPropertyValue("DeviceId").ToString()).Replace("Microsoft:", ""));
                            if (!VMCpuCache.ContainsKey(_id)) { VMCpuCache.Add(_id, _val); }
                            else if (!VMCpuCache[_id].Contains(_val))
                            {
                                VMCpuCache[_id] += "," + _val;
                            }
                        }
                    }
                    if (VMCpuCache.TryGetValue(vmid, out processorids)) { return processorids.Split(',').Length; }
                }
                return result;
            }
        }

        private VmStorageConfig GetVmDiskInfo(string id)
        {
            VmStorageConfig result = new VmStorageConfig();

            List<VirtualDisk> vmdisks = GetVmDiskCached(id);

            foreach (VirtualDisk disk in vmdisks)
            { 
                result.Allocated += disk.Allocated;
                result.Used += disk.Used;
            }
            return result;
        }

        internal Dictionary<string, HostSystem> GetHostCached()
        {
            lock (_HVHostsLock)
            {
                foreach (HostSystem host in _HVHosts.Values)
                {
                    if (!host.Loaded)
                    {
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT caption, version FROM Win32_OperatingSystem"))).Get())
                        {
                            string osver = r.GetPropertyValue("Caption").ToString();
                            osver = osver.Replace("Microsoft ", "");
                            osver = osver.Replace(" Evaluation", "");
                            host.Version = osver;
                            host.Build = r.GetPropertyValue("Version").ToString();
                        }
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT uuid FROM Win32_ComputerSystemProduct"))).Get())
                        {
                            host.Id = r.GetPropertyValue("uuid").ToString();
                        }
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT numberofprocessors, numberoflogicalprocessors, model, manufacturer FROM Win32_ComputerSystem"))).Get())
                        {
                            host.Hardware.SystemInfo.Vendor = r.GetPropertyValue("Manufacturer").ToString();
                            host.Hardware.SystemInfo.Model = r.GetPropertyValue("Model").ToString();
                            host.Hardware.CpuInfo.NumCpuPackages = Convert.ToInt32(r.GetPropertyValue("NumberOfProcessors"));
                            host.Hardware.CpuInfo.NumCpuCores = Convert.ToInt32(r.GetPropertyValue("NumberOfLogicalProcessors"));
                        }

                        // get vm count
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT capacity FROM Win32_PhysicalMemory"))).Get())
                        {
                            host.Hardware.MemorySize = Convert.ToInt64(r.GetPropertyValue("Capacity"));
                        }
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT caption, name, elementname FROM Msvm_ComputerSystem WHERE caption='Virtual Machine'"))).Get())
                        {
                            VirtualMachine vm = new VirtualMachine();
                            vm.Id = r.GetPropertyValue("Name").ToString();
                            vm.Name = r.GetPropertyValue("ElementName").ToString();
                            host.Vm.Add(vm.Id, vm);
                        }

                        // get datastore count 
                        // only get information about mounted logical volumes 
                        foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT * FROM Win32_Volume WHERE drivetype='3'"))).Get())
                        {
                            if (!r.GetPropertyValue("name").ToString().ToLower().Contains("?"))
                            {
                                Datastore ds = new Datastore();
                                ds.ID = r.GetPropertyValue("DeviceId").ToString();
                                ds.Name = r.GetPropertyValue("Name").ToString();
                                host.Datastore.Add(ds.ID, ds);
                            }
                        }
                        host.Loaded = true;
                    }
                }
            }
            return _HVHosts;
        }

        internal Datastore GetDatastoreDiskCached(string id) {

            // this function returns duplicate datastores placed at different mount points
            Datastore result = null;
            lock (_DatastoreDiskCacheLock)
            {
                if (DatastoreDiskCache.TryGetValue(id, out result))
                {
                    return result;
                }
                else
                {
                    foreach (HostSystem host in GetHostCached().Values)
                    {
                        ManagementObjectCollection volumeinfo = (new ManagementObjectSearcher(host.Scopes["MSStorage"], new ObjectQuery("SELECT * FROM MSFT_Volume"))).Get();
                        ManagementObjectCollection diskinfo = (new ManagementObjectSearcher(host.Scopes["MSStorage"], new ObjectQuery("SELECT * FROM MSFT_Disk"))).Get();
                        foreach (ManagementObject vol in volumeinfo)
                        {
                            string volpath = vol.GetPropertyValue("Path").ToString();
                            string volid = vol.GetPropertyValue("ObjectId").ToString();
                            volid = volid.Split('"')[1];
                            volid = volid.Split(':')[0];
                            if (!DatastoreDiskCache.ContainsKey(volpath))
                            {
                                foreach (ManagementObject dis in diskinfo)
                                {
                                    string disid = dis.GetPropertyValue("ObjectId").ToString();
                                    disid = disid.Split('"')[1];
                                    disid = disid.Split(':')[0];
                                    if (disid.Contains(volid))
                                    {
                                        Datastore ds = new Datastore { };
                                        ds.ID = vol.GetPropertyValue("UniqueId").ToString();
                                        ds.Model = dis.GetPropertyValue("Model").ToString().Trim();
                                        ds.Vendor = dis.GetPropertyValue("Manufacturer").ToString().Replace(",","").Trim();

                                        int bustype = Convert.ToInt32(dis.GetPropertyValue("BusType"));
                                        ds.AccessMode = ((DsBusType)bustype).ToString().Replace("BusType", "");

                                        int healthstatus = Convert.ToInt32(dis.GetPropertyValue("HealthStatus"));
                                        ds.HealthStatus = (new DsHealthState(healthstatus)).ToString();

                                        ds.IsBoot = Convert.ToBoolean(dis.GetPropertyValue("IsBoot"));
                                        ds.IsClustered = Convert.ToBoolean(dis.GetPropertyValue("IsClustered"));
                                        ds.IsHighlyAvailable = Convert.ToBoolean(dis.GetPropertyValue("IsHighlyAvailable"));
                                        ds.IsReadOnly = Convert.ToBoolean(dis.GetPropertyValue("IsReadOnly"));
                                        ds.IsScaleout = Convert.ToBoolean(dis.GetPropertyValue("IsScaleout"));
                                        ds.IsSystem = Convert.ToBoolean(dis.GetPropertyValue("IsSystem"));
                                        ds.PhysicalSectorSize = Convert.ToInt32(dis.GetPropertyValue("PhysicalSectorSize"));
                                        ds.LogicalSectorSize = Convert.ToInt32(dis.GetPropertyValue("LogicalSectorSize"));

                                        int provisioningtype = Convert.ToInt32(dis.GetPropertyValue("ProvisioningType"));
                                        ds.ProvisioningType = (new DsProvisioningType(provisioningtype)).ToString();

                                        DatastoreDiskCache.Add(volpath, ds);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    DatastoreDiskCache.TryGetValue(id, out result);
                    return result;
                }
            }
        }

        internal List<EntityViewBase> FindHostSystems()
        {
            List<EntityViewBase> FoundEntities = new List<EntityViewBase> { };
            foreach (HostSystem host in GetHostCached().Values)
            {
                FoundEntities.Add(host);
            }
            return FoundEntities;
        }

        // need to improve caching logic and processing speed
        internal List<EntityViewBase> FindVirtualMachines()
        {
            List<EntityViewBase> FoundEntities = new List<EntityViewBase> { };
            foreach (HostSystem host in GetHostCached().Values)
            {
                foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT * FROM Msvm_ComputerSystem WHERE caption='Virtual Machine'"))).Get())
                {
                    // get related vm object or initialize it
                    VirtualMachine vm = null;
                    string vmid = r.GetPropertyValue("Name").ToString();
                    host.Vm.TryGetValue(vmid, out vm);
                    if (vm == null) { vm = new VirtualMachine(); vm.Name = r.GetPropertyValue("ElementName").ToString(); vm.Id = vmid; host.Vm.Add(vmid, vm); }

                    vm.Host = host.Name;
                    vm.State = Convert.ToInt32(r.GetPropertyValue("EnabledState"));
                    

                    // possible KVP dictionary values are (only works when powered on)
                    // FullyQualifiedDomainName, IntegrationServicesVersion, NetworkAddressIPv4, NetworkAddressIPv6
                    // OSBuildNumber, OSDistributionData, OSDistributionName, OSKernelVersion, OSMajorVersion, OSMinorVersion, OSName, OSPlatformId, OSVersion
                    // ProcessorArchitecture                    
                    ManagementObjectCollection vmGuestKVPCollection = r.GetRelated("Msvm_KvpExchangeComponent"); // have to use select * for above query as otherwise getrelated does not work
                    Dictionary<string, string> vmGuestKeyValues = new Dictionary<string, string> { };
                    foreach (ManagementObject element in vmGuestKVPCollection)
                    {
                        string[] xmlitems = element.Properties["GuestIntrinsicExchangeItems"].Value as string[];
                        vmGuestKeyValues = GetWmiXmlDictionary(xmlitems);
                    }

                    VmSettings guestsettings = GetVmSettingsCached(vm.Id);
                    vm.Version = guestsettings.Version.ToString();
                    
                    if (vmGuestKeyValues.Count > 0)
                    {
                        System.Net.IPAddress ipaddr = null;
                        System.Net.IPAddress.TryParse(vmGuestKeyValues["NetworkAddressIPv4"].Split(',')[0], out ipaddr);
                        vm.Guest.IP = ipaddr;
                        vm.Guest.ToolsVersion = vmGuestKeyValues["IntegrationServicesVersion"];
                        vm.Guest.OS = vmGuestKeyValues["OSName"] + " " + vmGuestKeyValues["OSVersion"];
                        vm.Guest.Name = vmGuestKeyValues["FullyQualifiedDomainName"];
                    }
                    vm.Hardware.MemoryMB = GetVmMemoryCached(vm.Id);
                    vm.Hardware.NumCoresPerSocket = 1;
                    vm.Hardware.NumCPU = GetVmCpuCached(vm.Id);
                    
                    vm.Storage = GetVmDiskInfo(vm.Id);
                    vm.Disks = GetVmDiskCached(vm.Id);

                    if (host.IsClusterMember) { vm.Cluster = _ClusterName; }

                    FoundEntities.Add(vm);
                }
            }
            return FoundEntities;
        }
        
        internal List<EntityViewBase> FindDatastores()
        {
            List<EntityViewBase> FoundEntities = new List<EntityViewBase> { };
            foreach (HostSystem host in GetHostCached().Values)
            {
                // only get information about mounted logical volumes 
                foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT * FROM Win32_Volume WHERE drivetype='3' AND NOT name LIKE '%?%'"))).Get())
                {
                    Datastore ds = null;
                    string dsid = r.GetPropertyValue("DeviceId").ToString();
                    ds = GetDatastoreDiskCached(dsid);

                    bool dsalreadyfound = false;
                    foreach (Datastore entity in FoundEntities) { if (entity.ID == ds.ID) { dsalreadyfound = true; break; } }

                    ds.Name = r.GetPropertyValue("Name").ToString();
                    long blocksize = 0, capacity = 0, freespace = 0;
                    Int64.TryParse(r.GetPropertyValue("BlockSize").ToString(), out blocksize);
                    Int64.TryParse(r.GetPropertyValue("Capacity").ToString(), out capacity);
                    Int64.TryParse(r.GetPropertyValue("FreeSpace").ToString(), out freespace);
                    ds.BlockSize = blocksize;
                    ds.Capacity = capacity;
                    ds.FreeSpace = freespace;
                    ds.FileSystem = r.GetPropertyValue("FileSystem").ToString();
                    List<string> owners = new List<string> { };
                    if (ds.IsClustered)
                    {
                        foreach (HostSystem h in GetHostCached().Values) { owners.Add(h.Name); }
                    }
                    else { owners.Add(host.Name); }
                    ds.Cluster = _ClusterName;
                    ds.Host = CFunctions.StringJoin(";", owners);

                    if (!dsalreadyfound) { FoundEntities.Add(ds); }

                }
            }
            return FoundEntities;
        }
        internal List<EntityViewBase> FindEntityViews(Type type)
        {
            List<EntityViewBase> FoundEntities = new List<EntityViewBase> { };
            // translate query into WMI
            if (type.ToString().Contains("HostSystem"))
            {
                FoundEntities = FindHostSystems();
            }
            else if (type.ToString().Contains("VirtualMachine"))
            {
                FoundEntities = FindVirtualMachines();
            }
            else if (type.ToString().Contains("Datastore"))
            {
                FoundEntities = FindDatastores();
            }

            return FoundEntities;
        }

        private List<VirtualDisk> GetVmDiskCached(string vmid)
        {
            List<VirtualDisk> result = null;
            lock (_VMDiskCacheLock)
            {
                if (VMDiskCache.TryGetValue(vmid, out result))
                {
                    return result;
                }
                else
                {
                    foreach (HostSystem host in GetHostCached().Values)
                    {
                        //foreach { ... check if vm powered on and return volumeinfo + diskinfo ... else return actual size on disk }
                        ManagementObjectCollection diskallocs = (new ManagementObjectSearcher(host.Scopes["Virtualization"], new ObjectQuery("SELECT * FROM Msvm_StorageAllocationSettingData WHERE parent LIKE '%InstanceId%'"))).Get();
                        foreach (ManagementObject diskalloc in diskallocs)
                        {
                            string[] diskuris = (string[])diskalloc.GetPropertyValue("HostResource");
                            if (diskuris != null) {
                                foreach (string diskuri in diskuris)
                                {
                                    Dictionary<string, string> diskinfo = GetWmiXmlDictionary(new string[] { host.GetVirtualHardDiskInfo(diskuri) });
                                    if (diskinfo != null)
                                    {
                                        VirtualDisk disk = new VirtualDisk();
                                        disk.ID = diskinfo["InstanceID"];
                                        disk.Name = diskinfo["ElementName"];
                                        disk.PhysicalSectorSize = Convert.ToInt32(diskinfo["PhysicalSectorSize"]);
                                        disk.LogicalSectorSize = Convert.ToInt32(diskinfo["LogicalSectorSize"]);
                                        disk.BlockSize = Convert.ToInt32(diskinfo["BlockSize"]);
                                        disk.Path = diskinfo["Path"];
                                        //disk.Path = @"\\" + host.Name + "\\" + diskinfo["Path"].Split(':')[1];
                                        disk.Mode = Convert.ToInt32(diskinfo["Format"]);
                                        disk.Type = Convert.ToInt32(diskinfo["Type"]);
                                        disk.Allocated = Convert.ToInt64(diskinfo["MaxInternalSize"]);
                                        disk.Used = long.Parse(host.GetFileObject(disk.Path).GetPropertyValue("FileSize").ToString());
                                        foreach(Datastore ds in host.Datastore.Values)
                                        {
                                            if ((disk.Path.Length > 3) && (disk.Path.ToLower().Contains(ds.Name.ToLower()))) {
                                                disk.Datastore = ds.ID;
                                            }
                                        }
                                        if (!VMDiskCache.ContainsKey(vmid))
                                        {
                                            VMDiskCache[vmid] = new List<VirtualDisk> { disk };
                                        }
                                        else { VMDiskCache[vmid].Add(disk); }
                                    }
                                }
                            }
                        }
                    }
                    VMDiskCache.TryGetValue(vmid, out result);
                    return result;
                }
            }
        }

        //https://blogs.msdn.microsoft.com/kebab/2014/06/24/sending-messages-and-commands-to-a-hyper-v-virtual-machine-guest-os-using-the-kvp-exchange/
        private Dictionary<string, string> GetWmiXmlDictionary(string[] xmlNodes, int ParseStyle = 0)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (xmlNodes.Length == 1) { ParseStyle = 1; }

            foreach (string xmlString in xmlNodes)
            {
                XmlDocument d = new XmlDocument();
                d.LoadXml(xmlString);

                string Name = null;
                string Value = null;

                foreach (XmlElement property in d.SelectNodes("/INSTANCE/PROPERTY"))
                {
                    if (string.IsNullOrEmpty(property.InnerText) == false)
                    {
                        foreach (XmlAttribute attrib in property.Attributes)
                        {
                            if (ParseStyle == 0) { 
                                if (attrib.Value == "Name") { Name = property.InnerText; }
                                if (attrib.Value == "Data") { Value = property.InnerText; }
                            }
                            if (ParseStyle == 1)
                            {
                                if (attrib.Name == "NAME")
                                {
                                    Name = attrib.Value; Value = property.InnerText;
                                    if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Value) && !result.ContainsKey(Name)) { result.Add(Name, Value); }
                                }
                            }
                        }
                    }
                }
                if (ParseStyle == 0) {
                    if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Value) && !result.ContainsKey(Name)) { result.Add(Name, Value); }
                }
            }
            return result;
        }

    }
}
