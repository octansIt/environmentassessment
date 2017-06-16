using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace EnvironmentAssessment.Common.HVAPI
{
    class HostSystem
    {
        internal string Name;
        internal Dictionary<string, ManagementScope> Scopes = new Dictionary<string, ManagementScope> { };

        public string Version { get; internal set; }
        public string Build { get; internal set; }
        public string LoginTime { get; internal set; }
        public ManagementClass Registry { get; internal set; }

        object _RegistryLock = new object();

        public HostSystem(string name, ConnectionOptions connectionoptions = null)
        {
            this.Name = name;
            WMIInitializeScopes(connectionoptions);
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

        internal void WMIInitializeScopes(ConnectionOptions connectionoptions = null)
        {
            if (((connectionoptions.Username == Environment.UserName) && (connectionoptions.Authority == "ntlmdomain:" + Environment.UserDomainName)) || (connectionoptions == null))
            {
                // using impersonation
                Log.Write("[WMI] Connecting to '" + @"\\" + Name + @"\root' using Windows Session Credentials [" + Environment.UserDomainName + @"\" + Environment.UserName + "]");
                this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2"));
                this.Scopes.Add("virtualization", new ManagementScope(@"\\" + this.Name + @"\root\virtualization"));
            }
            else
            {
                // using credentials
                Log.Write("[WMI] Connecting to '" + @"\\" + Name + @"\root' using specified credentials [" + connectionoptions.Authority.Replace("ntlmdomain:", "") + @"\" + connectionoptions.Username + "]");
                this.Scopes.Add("CIMV2", new ManagementScope(@"\\" + this.Name + @"\root\CIMV2", connectionoptions));
                this.Scopes.Add("virtualization", new ManagementScope(@"\\" + this.Name + @"\root\virtualization", connectionoptions));
            }
        }

        internal string GetRegistryString(object defkey, string subkey, string value)
        {
            if (WMIRegistryInitialized()) // continue if we can access registry remotely
            {
                ManagementBaseObject param = Registry.GetMethodParameters("GetStringValue");
                param["hDefKey"] = defkey;
                param["sSubKeyName"] = subkey;
                param["sValueName"] = value;
                string result = (string)Registry.InvokeMethod("GetStringValue", param, null).Properties["sValue"].Value;
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
