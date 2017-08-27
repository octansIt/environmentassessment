using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Net;

namespace EnvironmentAssessment.Common.HvApi
{
    class HostSystem : EntityViewBase
    {
        internal string _name = "";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                IPHostEntry hostInfo = null;
                try
                {
                    if (value.Length != 0)
                    {
                        hostInfo = Dns.Resolve(value.Trim()); // zzz - using this on purpose. don't want IPv6 support right now, as it would mess up site discovery logic
                        _name = hostInfo.HostName.ToString();
                        IP = hostInfo.AddressList[0];
                    }
                }
                catch { /* do nothing - should end up with old name and IP address */ }
            }
        }

        internal Dictionary<string, ManagementScope> Scopes = new Dictionary<string, ManagementScope> { };

        internal bool IsClusterMember = false;

        public string Version { get; internal set; }
        public string Build { get; internal set; }
        public string LoginTime { get; internal set; }
        public ManagementClass Registry { get; internal set; }

        public ManagementObject ImageManagement { get; internal set; }

        public string OS { get { return Version; } }
        public IPAddress IP { get; internal set; }
        public bool Connected { get; internal set; }
        public string Id { get; internal set; }
        public bool Loaded { get; internal set; }

        object _RegistryLock = new object();
        object _ImageManagementLock = new object();

        public HardwareConfig Hardware = new HardwareConfig();

        public Dictionary<string, VirtualMachine> Vm = new Dictionary<string, VirtualMachine> { };

        public Dictionary<string, Datastore> Datastore = new Dictionary<string, Datastore> { };

        public class HardwareConfig
        {
            public CpuConfig CpuInfo = new CpuConfig();
            public SystemConfig SystemInfo = new SystemConfig();

            public long MemorySize { get; internal set; }

            public class CpuConfig
            {
                public int NumCpuCores { get; internal set; }
                public int NumCpuPackages { get; internal set; }
            }
            public class SystemConfig
            {
                public string Model { get; internal set; }
                public string Vendor { get; internal set; }
            }
        }

        public HostSystem(string name, ConnectionOptions connectionoptions = null, bool isClusterMember = false, Dictionary<string, ManagementScope> scopes = null)
        {
            this.Name = name;
            this.IsClusterMember = isClusterMember;
            WMIInitializeScopes(connectionoptions, scopes);
        }

        public bool CheckRegistryAccess(object defkey, string subkey, object permission)
        {
            if (WMIRegistryInitialized()) // continue if we can access registry remotely
            {
                // invoke WMI registry query to check registry access
                ManagementBaseObject param = this.Registry.GetMethodParameters("CheckAccess");
                param["hDefKey"] = defkey;
                param["sSubKeyName"] = subkey;
                param["uRequired"] = permission;
                ManagementBaseObject result = this.Registry.InvokeMethod("CheckAccess", param, null);

                if (result["bGranted"].ToString() == "True") { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }

        }

        internal List<string> EnumRegistrySubkeys(object defkey, string subkey)
        {
            List<string> output = null;
            if (WMIRegistryInitialized()) // continue if we can access registry remotely
            {
                ManagementBaseObject param = Registry.GetMethodParameters("EnumKey");
                param["hDefKey"] = defkey;
                param["sSubKeyName"] = subkey;
                string[] results = (string[])Registry.InvokeMethod("EnumKey", param, null).Properties["sNames"].Value;

                output = new List<string> { };
                output.AddRange(results);
                
                return output;
            }
            else
            {
                return output;
            }
        }

        internal bool WMIRegistryInitialized()
        {
            
            if ((this.Registry == null) && (this.Scopes["CIMV2"] != null))
            {
                lock (_RegistryLock)
                {
                    this.Registry = new ManagementClass(this.Scopes["CIMV2"], new ManagementPath("StdRegProv"), null);
                }
            }
            
            if (this.Registry != null) { return true; }
            else { return false; }
        }

        internal bool WMIImageManagementInitialized()
        {

            if ((this.ImageManagement == null) && (this.Scopes["Virtualization"] != null))
            {
                lock (_ImageManagementLock)
                {
                    ManagementClass imgmgmtservices = new ManagementClass(this.Scopes["Virtualization"], new ManagementPath("Msvm_ImageManagementService"), null);
                    foreach (ManagementObject service in imgmgmtservices.GetInstances())
                    {
                        this.ImageManagement = service;
                    }
                }
            }

            if (this.ImageManagement != null) { return true; }
            else { return false; }
        }

        internal void WMIInitializeScopes(ConnectionOptions connectionoptions = null, Dictionary<string, ManagementScope> scopes = null)
        {
            if (((connectionoptions.Username == Environment.UserName) && (connectionoptions.Authority == "ntlmdomain:" + Environment.UserDomainName)) || (connectionoptions == null))
            {
                // using impersonation
                if (scopes != null) { this.Scopes = scopes; }
                else
                {
                    Log.Write("[HvApi] Connecting to '" + @"\\" + Name.ToLower() + @"\root' using Windows Session Credentials [" + Environment.UserDomainName + @"\" + Environment.UserName + "]");
                    this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2"));
                    this.Scopes.Add("Virtualization", new ManagementScope(@"\\" + this.Name + @"\root\virtualization\v2"));
                    this.Scopes.Add("MSStorage", new ManagementScope(@"\\" + this.Name + @"\root\microsoft\windows\storage"));
                }
                if (IsClusterMember) { this.Scopes.Add("MSCluster", new ManagementScope(@"\\" + this.Name + @"\root\MSCluster")); }
            }
            else
            {
                // using credentials
                if (scopes != null) { this.Scopes = scopes; }
                else
                {
                    Log.Write("[HvApi] Connecting to '" + @"\\" + Name.ToLower() + @"\root' using specified credentials [" + connectionoptions.Authority.Replace("ntlmdomain:", "") + @"\" + connectionoptions.Username + "]");
                    this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2", connectionoptions));
                    this.Scopes.Add("Virtualization", new ManagementScope(@"\\" + this.Name + @"\root\virtualization\v2", connectionoptions));
                    this.Scopes.Add("MSStorage", new ManagementScope(@"\\" + this.Name + @"\root\microsoft\windows\storage", connectionoptions));
                }
                if (IsClusterMember) { this.Scopes.Add("MSCluster", new ManagementScope(@"\\" + this.Name + @"\root\MSCluster", connectionoptions)); }
            }
        }

        internal ManagementObject GetFileObject(string path)
        {
            ManagementObject result = null;
            path = path.Replace(@"\", @"\\");
            foreach (ManagementObject r in (new ManagementObjectSearcher(Scopes["CIMV2"], new ObjectQuery("SELECT * FROM CIM_DataFile WHERE name='" + path + "'"), new EnumerationOptions() { BlockSize = 1 }).Get()))
            {
                result = r;
            }
            return result;
        }

        internal string GetVirtualHardDiskInfo(string path)
        {
            if (WMIImageManagementInitialized())
            {
                ManagementBaseObject inparam = this.ImageManagement.GetMethodParameters("GetVirtualHardDiskSettingData");
                inparam["Path"] = path;
                ManagementBaseObject outparam = ImageManagement.InvokeMethod("GetVirtualHardDiskSettingData", inparam, null);
                string result = null;
                if (outparam != null) {
                    if ((UInt32)outparam["ReturnValue"] == HvWmiReturnCode.Started)
                    {
                        while (WMIJobCompleted(Scopes["Virtualization"], outparam))
                        {
                            result = outparam["SettingData"].ToString();
                        }
                        if ((UInt32)outparam["ReturnValue"] == HvWmiReturnCode.Completed)
                        {
                            result = outparam["Info"].ToString();
                        }
                    }
                    else if ((UInt32)outparam["ReturnValue"] == HvWmiReturnCode.Completed)
                    {
                        result = outparam["SettingData"].ToString();
                    }
                }
                return result;
            }
            else {
                return null;    
            }
        }

        internal bool WMIJobCompleted(ManagementScope scope, ManagementBaseObject param)
        {
            bool result = true;
            ManagementObject job = new ManagementObject(scope, new ManagementPath(param["Job"].ToString()), null);
            job.Get();
            while ((UInt16)job["JobState"] == HvWmiJobState.Starting || (UInt16)job["JobState"] == HvWmiJobState.Running)
            {
                //Log.Write(CFunctions.StringReplace("[HvApi] Querying " + param["Path"] + ": {0}% complete.", job["PercentComplete"].ToString()));
                System.Threading.Thread.Sleep(COptions.HV_Thread_Wait);
                job.Get();
            }

            if ((UInt16)job["JobState"] != HvWmiJobState.Completed)
            {
                UInt16 errorcode = (UInt16)job["ErrorCode"];
                //Log.Write(CFunctions.StringReplace("[HvApi] Error: Query failed: {0}: {1}", errorcode.ToString(), (string)job["ErrorDescription"]));
                result = false;
            }
            return result;
        }

        internal string GetRegistryString(object defkey, string subkey, string value)
        {
            if (WMIRegistryInitialized()) // continue if we can access registry remotely
            {
                ManagementBaseObject inparam = Registry.GetMethodParameters("GetStringValue");
                inparam["hDefKey"] = defkey;
                inparam["sSubKeyName"] = subkey;
                inparam["sValueName"] = value;
                ManagementBaseObject outparam = Registry.InvokeMethod("GetStringValue", inparam, null);
                string result = null;
                if (outparam != null) { result = outparam.Properties["sValue"].Value.ToString(); }
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
