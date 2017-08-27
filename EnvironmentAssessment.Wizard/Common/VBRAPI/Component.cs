using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace EnvironmentAssessment.Common.VbrApi
{
    public class ComponentType : IDisposable
    {
        private int _type;

        private static string[] Values = { "Backup Server", "Backup Enterprise Manager", "Backup Proxy", "Tape Proxy", "Guest Interaction Proxy", "CDP Proxy", "File Proxy", "Backup Repository", "WAN Accelerator", "Mount Server", "Gateway Server", "Cloud Gateway" };

        public const int BackupServer = 0;
        public const int BackupEnterpriseManager = 1;
        public const int BackupProxy = 2;
        public const int TapeProxy = 3;
        public const int GuestInteractionProxy = 4;
        public const int CDPProxy = 5;
        public const int FileProxy = 6;
        public const int BackupRepository = 7;
        public const int WANAccelerator = 8;
        public const int MountServer = 9;
        public const int RepositoryGateway = 10;
        public const int CloudGateway = 11;

        public ComponentType(string s = "")
        {
            _type = Array.IndexOf(Values, s);
        }
        public ComponentType(int t = -1)
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

        public static implicit operator int(ComponentType x)
        {
            int i = x._type;
            return i;
        }
    }

    class Component : EntityViewBase
    {
        public string Name { get; private set; }
  
        public ManagementClass Registry { get; internal set; }

        internal Dictionary<string, ManagementScope> Scopes = new Dictionary<string, ManagementScope> { };

        public int Type { get; set; }
        public string Version { get; internal set; }
        public string Build { get; internal set; }
        public string LoginTime { get; internal set; }
        public string ID { get; internal set; }
        public bool Connected { get; internal set; }

        public Component Parent = null;
        public Dictionary<string, Component> Children = new Dictionary<string, Component> { };

        public bool IsConnectable = false;

        private object _RegistryLock = new Object();
        
        public Component(string name, int type = ComponentType.BackupServer, ConnectionOptions connectionoptions = null)
        {
            this.Name = name;
            this.Type = type;
            WMIInitializeScopes(connectionoptions);
        }

        public Component(string name, int type = ComponentType.BackupServer)
        {
            IsConnectable = false;
            this.Name = name;
            this.Type = type;
        }

        internal void WMIInitializeScopes(ConnectionOptions connectionoptions = null)
        {
            if (((connectionoptions.Username == Environment.UserName) && (connectionoptions.Authority == "ntlmdomain:" + Environment.UserDomainName)) || (connectionoptions == null))
            {
                // using impersonation
                Log.Write("[VbrApi] Connecting to '" + @"\\" + Name + @"\root' using Windows Session Credentials [" + Environment.UserDomainName + @"\" + Environment.UserName + "]");
                if (Type == ComponentType.BackupServer)
                {
                    this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2"));
                    this.Scopes.Add("VeeamBS", new ManagementScope(@"\\" + this.Name + @"\root\VeeamBS"));
                }
            }
            else
            {
                // using credentials
                Log.Write("[VbrApi] Connecting to '" + @"\\" + Name + @"\root' using specified credentials [" + connectionoptions.Authority.Replace("ntlmdomain:", "") + @"\" + connectionoptions.Username + "]");
                if (Type == ComponentType.BackupServer)
                {
                    this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2", connectionoptions));
                    this.Scopes.Add("VeeamBS", new ManagementScope(@"\\" + this.Name + @"\root\VeeamBS", connectionoptions));
                }
            }
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

    }
}
