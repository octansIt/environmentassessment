using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Common.VbrApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Collector
{
    class VbrSession : ISession
    {
        internal string SessionID;
        VbrClient VBClient = null;
        Component VBSession = null;
        private List<CSite> _SiteInfo;

        public VbrSession(ref CService _Server)
        {
            Server = _Server;
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
                Error = CNetwork.CheckPortStatus(Server.IP, VbrClient.DefaultPort);

                if (Error.Length == 0)
                {
                    VBClient = new VbrClient();
                    if (Server.UserName == Environment.UserDomainName + "\\" + Environment.UserName) { VBSession = VBClient.LoginWithCurrentCredentials(this); }
                    else { VBSession = VBClient.Login(this); } // otherwise use username and password
                    if (VBSession.Connected) { Connected = true; }
                }
            }
            return result;
        }

        internal List<CDiscoveredConfig> GetComponents(int queryid)
        {
            List<CDiscoveredConfig> ComponentsFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> components = null;

            // dont continue if not logged in
            if (VBClient == null) { return ComponentsFound; }

            /* try { Log.Write("[WMI] Querying proxies associated with: " + Server.Name.ToUpper()); proxies = VBClient.FindEntityViews(new ComponentType(ComponentType.BackupProxy)); }
            catch (Exception ex) { Log.Write("Cannot query proxy information. Error: " + ex.TargetSite + ex.Message); }

            _SiteInfo = Server.Session.Queries[queryid].Sites;

            if (proxies != null)
            {
                Log.Write(CFunctions.StringReplace("Found proxies ({0}) associated with {1}", proxies.Count.ToString(), Server.Name.ToUpper()));
                foreach (Component proxy in proxies)
                { */
            //if (VBClient.ServerType == VBClient.VBServerType.BackupServer)

            /* CServiceConfig hostinfo = new CServiceConfig()
            {

                Site = CSite.Resolve(host.IP, _SiteInfo),
                Name = host.Name.ToString(),
                IP = host.IP,
                OS = host.OS,
                CPUSockets = host.Hardware.CpuInfo.NumCpuPackages,
                CPUCores = host.Hardware.CpuInfo.NumCpuCores,
                RAM = (Int64)Math.Round((host.Hardware.MemorySize / Math.Pow(1024, 2)), MidpointRounding.AwayFromZero),
                _HardwareVersion = (host.Hardware.SystemInfo.Vendor + " " + host.Hardware.SystemInfo.Model).Replace(",", String.Empty),
                State = new CDiscoveredState(), //GetVIObjectState(host),
                Cluster = cluster,
                Datacenter = "",
                Children = new List<string> { host.Vm.Count().ToString(), host.Datastore.Count().ToString() }
            };

            string logdata = "  ";
            if (hostinfo.Site != null) { logdata = hostinfo.Site.Name + ","; }
            if (hostinfo.Datacenter.Length > 0) { logdata += hostinfo.Datacenter + ","; }
            if (hostinfo.Cluster.Length > 0) { logdata += hostinfo.Cluster + ","; }

            logdata += hostinfo.Name + "," + hostinfo.IP + "," + hostinfo.OS + "," + hostinfo.CPUSockets + " (" + hostinfo.CPUCores + " cores),memory:" + hostinfo.RAM + " (MB)," + hostinfo._HardwareVersion;
            Log.Write(logdata, Log.Verbosity.Debug); */

            //ProxiesFound.Add(hostinfo);
            //}
            //}

            return ComponentsFound;
        }

        internal List<CDiscoveredConfig> GetEvents(int queryid)
        {
            List<CDiscoveredConfig> PropertiesFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> properties = null;
            return PropertiesFound;
        }
    }
}
