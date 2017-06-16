using System;
using System.Management;
using EnvironmentAssessment.Collector;
using System.Collections.Generic;

namespace EnvironmentAssessment.Common.HVAPI
{
    class HviClient : IClient
    {
        internal const ushort DefaultPort = 135;
        internal string _version = null;
        internal string _build = null;
        internal string _logintime = null;
        internal ConnectionOptions _connectionOptions;
        internal Dictionary<string, HostSystem> _HVClusterNodes = null;

        void Connect()
        {

        }

        public object Login(ISession session)
        {
            _connectionOptions = new ConnectionOptions();
            if (session.Server.UserName.Contains("\\"))
            {
                _connectionOptions.Username = session.Server.UserName.Split('\\')[1];
                _connectionOptions.Authority = "ntlmdomain:" + session.Server.UserName.Split('\\')[0];
                _connectionOptions.Password = session.Server.UserPassword;
            }
            else
            {
                _connectionOptions.Username = session.Server.UserName;
                _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
                _connectionOptions.Password = session.Server.UserPassword;
            }

            return DoLogin(session);

        }

        public object LoginWithCurrentCredentials(ISession session)
        {
            _connectionOptions.Username = Environment.UserName;
            _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
            _connectionOptions.Password = "";

            return DoLogin(session);

        }

        public object DoLogin(ISession session)
        {
            HostSystem host = new HostSystem(session.Server.Name, _connectionOptions);

            try
            {
                foreach (ManagementObject r in (new ManagementObjectSearcher(host.Scopes["CIMV2"], new ObjectQuery("SELECT caption, version FROM Win32_OperatingSystem"))).Get())
                {
                    host.Version = r.GetPropertyValue("Caption").ToString().Replace("Microsoft ", "");
                    host.Build = r.GetPropertyValue("Version").ToString();
                }
                if (_version != null)
                {
                    host.LoginTime = Common.CFunctions.GetDateTime(1);
                    Log.Write("[WMI] Logged into '" + @"\\" + session.Server.Name + @"\root' at " + (host.LoginTime) + " (" + host.Build + ").");
                }
            }
            catch (Exception ex)
            {
                session.Error = ex.Message;
                Log.Write("[WMI] Login into '" + @"\\" + session.Server.Name + @"\root failed: " + session.Error);
                return null;
            }

            // check if host is a member of a cluster
            if (host.CheckRegistryAccess(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", CRegistry.KEY_ENUMERATE_SUB_KEYS))
            {
                // if so find child entries and add those to _HVHosts
                string clustername = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", "ClusterName");
                if (session.Server.Name != clustername) { session.Server.Name = clustername; } // rename host to cluster name

                List <string> nodes = host.EnumRegistrySubkeys(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes");
                Dictionary<string, HostSystem> _HVClusterNodes = new Dictionary<string, HostSystem> { };
                foreach (string n in nodes)
                {
                    string nodename = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes\" + n, "NodeName");
                    _HVClusterNodes.Add(nodename, new HostSystem(nodename, _connectionOptions));
                }
            }

            return null;
        }

        void Disconnect()
        {

        }

        internal ManagementObjectCollection FindManagedObjects(string q)
        {
            return null;
            /* ManagementObjectSearcher searcher = new ManagementObjectSearcher(HostSystem.Scopes["virtualization"], new ObjectQuery(q));
            ManagementObjectCollection result = searcher.Get();
            try
            {
                if (result.Count > 0) { return result; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null; */
        }
    }
}
