using EnvironmentAssessment.Collector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace EnvironmentAssessment.Common.VbrApi
{
    class VbrClient : IClient
    {
        internal const ushort DefaultPort = 135;

        internal string _version = null;
        internal ConnectionOptions _connectionOptions;
        internal Dictionary<string, Component> _VBRComponents;
        public Component Login(ISession session)
        {
            _connectionOptions = new ConnectionOptions();
            if (session.Server.UserName.Contains("\\"))
            {
                _connectionOptions.Username = session.Server.UserName.Split('\\')[1];
                _connectionOptions.Authority = "ntlmdomain:" + session.Server.UserName.Split('\\')[0];
                _connectionOptions.Password = session.Server.UserPassword;
                _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
            }
            else
            {
                _connectionOptions.Username = session.Server.UserName;
                _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
                _connectionOptions.Password = session.Server.UserPassword;
                _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
            }

            return DoLogin(session);

        }

        public Component LoginWithCurrentCredentials(ISession session)
        {
            _connectionOptions.Username = Environment.UserName;
            _connectionOptions.Authority = "ntlmdomain:" + Environment.UserDomainName;
            _connectionOptions.Password = "";
            _connectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;

            return DoLogin(session);

        }

        public Component DoLogin(ISession session)
        {
            Component server = new Component(session.Server.Name, ComponentType.BackupServer, _connectionOptions);

            try
            {
                foreach (ManagementObject r in (new ManagementObjectSearcher(server.Scopes["CIMV2"], new ObjectQuery("SELECT caption, version FROM Win32_OperatingSystem"))).Get())
                {
                    string osver = r.GetPropertyValue("Caption").ToString();
                    osver = osver.Replace("Microsoft ", "");
                    osver = osver.Replace(" Evaluation", "");
                    server.Version = osver;
                    server.Build = r.GetPropertyValue("Version").ToString();
                }
                if (_version != null)
                {
                    server.LoginTime = Common.CFunctions.GetDateTime(1);
                    Log.Write("[VbrApi] Logged into '" + @"\\" + session.Server.Name + @"\root' at " + (server.LoginTime) + " (" + server.Build + ").");
                }
            }
            catch (Exception ex)
            {
                session.Error = ex.Message;
                Log.Write("[VbrApi] Login into '" + @"\\" + session.Server.Name + @"\root failed: " + session.Error);
                return null;
            }

            server.Connected = true;

            // zzz: need to add VBEM support

            /* check if host is a member of a cluster
            if (server.CheckRegistryAccess(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", CRegistry.KEY_ENUMERATE_SUB_KEYS))
            {
                HostType = new HvHostType(HvHostType.Cluster);

                // if so find child entries and add those to _HVHosts
                string dnssuffix = session.Server.Name.Substring(session.Server.Name.IndexOf('.'));
                string clustername = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, "Cluster", "ClusterName") + dnssuffix;
                if (session.Server.Name != clustername)
                {
                    session.Server.Name = clustername; // rename host to cluster name
                }

                List<string> nodes = host.EnumRegistrySubkeys(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes");
                _HVHosts = new Dictionary<string, HostSystem> { };
                foreach (string n in nodes)
                {
                    string nodename = host.GetRegistryString(CRegistry.HKEY_LOCAL_MACHINE, @"Cluster\Nodes\" + n, "NodeName") + dnssuffix;
                    HostSystem node = new HostSystem(nodename, _connectionOptions, true);
                    _HVHosts.Add(nodename, node);
                }
            } */
            _VBRComponents = new Dictionary<string, Component> { };
            _VBRComponents.Add(server.Name, server);

            return server;
        }

        void Disconnect()
        {

        }

        internal List<EntityViewBase> FindEntityViews(ComponentType type)
        {
            List<EntityViewBase> FoundEntities = new List<EntityViewBase> { };
            // translate query into WMI
            if (type.ToString().Contains("BackupProxy"))
            { 
                foreach (Component server in _VBRComponents.Values)
                {
                    if (server.Type == ComponentType.BackupServer)
                    {
                        foreach (ManagementObject r in (new ManagementObjectSearcher(server.Scopes["CIMV2"], new ObjectQuery("SELECT caption, version FROM Win32_OperatingSystem"))).Get())
                        {
                            string osver = r.GetPropertyValue("Caption").ToString();
                            osver = osver.Replace("Microsoft ", "");
                            osver = osver.Replace(" Evaluation", "");
                            server.Version = osver;
                            server.Build = r.GetPropertyValue("Version").ToString();
                        }
                        foreach (ManagementObject r in (new ManagementObjectSearcher(server.Scopes["VeeamBS"], new ObjectQuery("SELECT instanceuid, version, name, disabled FROM Proxy"))).Get())
                        {
                            string name = r.GetPropertyValue("Name").ToString();
                            string instanceid = r.GetPropertyValue("InstanceUid").ToString();
                            Component proxy = new Component(name, new ComponentType(ComponentType.BackupProxy));
                            proxy.ID = instanceid;
                            server.Children.Add(instanceid, proxy);
                        }

                        FoundEntities.Add(server);
                    }
                }
            }
            
            return FoundEntities;
        }

    }
}
