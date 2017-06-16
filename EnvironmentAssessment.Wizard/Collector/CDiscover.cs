using System;
using System.Collections.Generic;
using System.Linq;
using System.DirectoryServices;

namespace EnvironmentAssessment.Collector
{
    using Common;
    using EnvironmentAssessment.Common.Inventory;
    using System.IO;
    using System.Management;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Threading;

    public class CDiscoveryType : IDisposable
    {
        private int _type;

        private static string[] DiscoverTypes = { "Discovery Without Portscan", "Discovery With Portscan" };

        public const int WithoutPortScan = 0; // queries objects without checking ports where possible
        public const int WithPortScan = 1; // queries objects and check ports

        public CDiscoveryType(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            DiscoverTypes = null;
        }

        public override string ToString()
        {
            return DiscoverTypes[_type];
        }

        public static implicit operator int(CDiscoveryType x)
        {
            int i = x._type;
            return i;
        }
    }

    public class CDiscoveryManager : IDisposable
    {
        private static string _DomainName;
        private HashSet<string> _ServerPortScanResults;
        private HashSet<string> _ServerCheckCredentialEventsResults;
        private DirectoryEntry rootDSE;
        private Dictionary<string, CService> _DomainControllers;
        private object _ServerPortScanLock = new Object();
        private CDiscoveryType _DiscoveryType = new CDiscoveryType(CDiscoveryType.WithPortScan);

        public IEnumerable<IDiscoveredObject> GetInventory(int discoverytype = -1)
            {
                // Log.Write(" : GetInventory (discoverytype: " + discoverytype + ")", Log.Verbosity.Everything);
                CCollectionSchedule m = new CCollectionSchedule(CCollectionSchedule.RunOnce);
                CDiscoveryType t = new CDiscoveryType(discoverytype);
                IEnumerable<IDiscoveredObject> result = _GetInventory(m, t);
            // Log.Write(" : GetInventory (completed)", Log.Verbosity.Everything);
            return result;
            }

        public List<IDiscoveredObject> _GetInventory(CCollectionSchedule collectionschedule, CDiscoveryType discoverytype)
        {
            _DiscoveryType = discoverytype;
            List<IDiscoveredObject> DiscoveredObjects = new List<IDiscoveredObject> { };
            DiscoveredObjects.AddRange(GetServers().Values);
            return DiscoveredObjects;
        }

        // try to discover existing servers with data from active directory if possible
        public Dictionary<string, CService> GetServers()
        {
            Dictionary<string, CService> _DiscoveredServers = new Dictionary<string, CService> { };
            if (rootDSE == null) { rootDSE = new DirectoryEntry("LDAP://RootDSE"); }

            // get default ad naming context
            _DomainName = GetDomain();

            if (_DomainName != null)
            {
                // get domain controller information
                //if (_DomainControllers == null) { _DomainControllers = GetDomainServers(); }

                // get servers using domain for credential validation
                // GetCheckCredentialEvents()

                Log.Write("Discovering Servers");
                foreach (CServiceType type in COptions.DiscoverServers)
                {
                    if (type == CServiceType.SCVMMServer) { _DiscoveredServers.AddRange(GetSCVMMServers()); }
                    if (type == CServiceType.HYVServer) { _DiscoveredServers.AddRange(GetHyperVServers()); }
                    if (type == CServiceType.VCenterServer) { _DiscoveredServers.AddRange(GetVCenterServers()); }
                }

                // cleanup servers we discovered but do not have the correct services running (multi-threaded)
                if (_DiscoveryType == CDiscoveryType.WithPortScan)
                {
                    _DiscoveredServers = CheckServiceIfRequired(_DiscoveredServers);
                }

            }

            return _DiscoveredServers;
        }

        private Dictionary<string, CService> CheckServiceIfRequired(Dictionary<string, CService> _ServicesToCheck)
        {
            List<CThread> ScanTasks = new List<CThread> { };
            Dictionary<string, CService> _CheckedServers = new Dictionary<string, CService> { };
            _ServerPortScanResults = new HashSet<string> { };

            foreach (CService s in _ServicesToCheck.Values)
            {
                int port = 0; string search = null; CNetwork.Protocols protocol = null;
                
                if (s.Type == CServiceType.VCenterServer) { port = 80; search = "VMware vSphere"; protocol = new CNetwork.Protocols(CNetwork.Protocols.HTTP); }
                if (s.Type == CServiceType.HYVServer || s.Type == CServiceType.SCVMMServer) { port = 135; search = "RPC Endpoint Mapper"; protocol = new CNetwork.Protocols(CNetwork.Protocols.RPC); }

                if (port > 0)
                {
                    CThread scan = new CThread() { Worker = new Thread(new ThreadStart(delegate () { DoPortScan(s, port, protocol, search); })) };
                    ScanTasks.Add(scan); Core.ThreadManager.Add(scan);
                }
                else { _CheckedServers.Add(s.Name + ";" + s.Type.ToString(), s); }
            }

            bool ScanTaskCompleted = false;

            do // wait till completed
            {
                bool status = true;
                for (int i = 0; i < ScanTasks.Count; i++) { if (!ScanTasks[i].Completed) { status = false; } }
                ScanTaskCompleted = status;
                Thread.Sleep(COptions.Session_Thread_Wait);

            } while (!ScanTaskCompleted);

            foreach (string s in _ServerPortScanResults)
            {
                string name = s.Split(';')[0];
                string type = s.Split(';')[1];
                _CheckedServers.Add(name + ";" + type, _ServicesToCheck[name + ";" + type]);
            }

            return _CheckedServers;
        }

        public List<CSite> GetSites()
        {
            // get site data from AD
            List<CSite> SitesFound = new List<CSite> { };
            if (rootDSE == null) { rootDSE = new DirectoryEntry("LDAP://RootDSE"); }
            SearchResultCollection QueryResult = null;

            _DomainName = GetDomain();

            // do not continue unless we have a valid domain
            if (_DomainName == null)
            {
                Log.Write("Cannot auto-discover. Current system (" + Environment.UserDomainName.ToUpper() + ") is not domain joined.");
                return SitesFound;
            }

            // search for site objects
            QueryResult = QueryActiveDirectory(rootDSE.Properties["configurationNamingContext"].Value.ToString(), "(objectClass = site)", new List<string> { "adspath", "name", "location", "description" });

            if (QueryResult != null)
            {
                string strLogData = "";
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string sitename = "", adpath = "", location = "", description = "";
                    sitename = QueryResult[i].Properties["name"][0].ToString();
                    adpath = QueryResult[i].Properties["adspath"][0].ToString();
                    if (QueryResult[i].Properties["location"].Count > 0) { location = QueryResult[i].Properties["location"][0].ToString(); }
                    if (QueryResult[i].Properties["description"].Count > 0) { description = QueryResult[i].Properties["description"][0].ToString(); }
                    strLogData += sitename + " (" + location + "), ";
                    SitesFound.Add(new CSite(sitename, adpath, location, description));
                }

            }

            // search for subnet objects
            QueryResult = QueryActiveDirectory(rootDSE.Properties["configurationNamingContext"].Value.ToString(), "(objectClass=subnet)", new List<string> { "name", "description", "siteObject", "location" });
            
            if (QueryResult != null)
            {
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string name = "", siteobject = "", location = "", description = "";
                    name = QueryResult[i].Properties["name"][0].ToString();
                    siteobject = QueryResult[i].Properties["siteObject"][0].ToString();
                    if (QueryResult[i].Properties["location"].Count > 0) { location = QueryResult[i].Properties["location"][0].ToString(); }
                    if (QueryResult[i].Properties["description"].Count > 0) { description = QueryResult[i].Properties["description"][0].ToString(); }

                    for (int j = 0; j < SitesFound.Count(); j++)
                    {
                        if (SitesFound[j].Path.Contains(siteobject))
                        {
                            SitesFound[j].Subnets.Add(name);
                        }
                    }
                }

                // report on discovered sites
                string strLogData = "";

                for (int i = 0; i < SitesFound.Count(); i++)
                {
                    strLogData = SitesFound[i].Name + " (";
                    for (int j = 0; j < SitesFound[i].Subnets.Count; j++)
                    {
                        strLogData += SitesFound[i].Subnets[j] + ", ";
                    }

                    if (strLogData.Length > 0) { Log.Write(String.Format("\tSites: {{{0}}}", strLogData)); }
                }
            }

            SitesFound = SitesFound.OrderBy(o => o.Name).ToList(); // sort alphabetically
            return SitesFound;

        }


        private Dictionary<string, CService> GetVCenterServers()
        {
            Dictionary<string, CService> ServersFound = new Dictionary<string, CService> { };

            foreach (CService s in GetVCenterServersUsingSCP().Values)
            {
                if (!ServersFound.ContainsKey(s.Name + ";" + s.Type.ToString())) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); } 
            }
            foreach (CService s in GetVCenterAppliancesUsingLikewise().Values)
            {
                if (!ServersFound.ContainsKey(s.Name + ";" + s.Type.ToString())) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); } 
            }

            string log = ""; if (ServersFound.Count > 0) { log += "vCenter servers {"; }
            foreach (CService s in ServersFound.Values)
            {
                log += s.Name + ", " + s.IP + "; ";
            }
            Log.Write(log + "}", Log.Verbosity.Verbose);

            return ServersFound;
        }

        private void GetCheckCredentialEvents()
        {
            foreach(CService dc in _DomainControllers.Values)
            {
                // [tbd] split-off into seperate function to run each as seperate thread
                ConnectionOptions connectionopts = new ConnectionOptions();
                connectionopts.Impersonation = ImpersonationLevel.Impersonate;
                connectionopts.EnablePrivileges = true;

                string starttime = System.Management.ManagementDateTimeConverter.ToDmtfDateTime((DateTime.Now).AddMinutes(-1)); // can easily expect a high volume of events (~500 per minute)
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    new ManagementScope("\\\\" + dc.Name + "\\root\\CIMV2", connectionopts), 
                    new ObjectQuery(@"SELECT * FROM Win32_NTLogEvent WHERE (Logfile = 'Security') AND (EventCode='4776') AND (Category='14336') AND (TimeWritten>'" + starttime + "')")
                );

                foreach (ManagementObject obj in searcher.Get())
                {
                    String[] istr = (String[])(obj["InsertionStrings"]);
                    string account = istr[1];
                    string server = istr[2];
                    // [tbd] add locking variable, ensure results variable is initialized
                    if (!_ServerCheckCredentialEventsResults.Contains(server + ";" + account))
                    {
                        _ServerCheckCredentialEventsResults.Add(server + ";" + account);
                    }
                }
            }
        }
        
        private static Dictionary<string, CService> GetVCenterServersUsingSCP()
        {
            Dictionary<string,CService> ServersFound = new Dictionary<string, CService> { };
            SearchResultCollection QueryResult = null;
            QueryResult = QueryActiveDirectory(_DomainName, "(&(objectClass=serviceConnectionPoint)(keywords=instance:VMwareVCMSDS))", new List<string> { "servicednsname" });

            if (QueryResult != null)
            {
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult= QueryResult[i].Properties["servicednsname"][0].ToString();
                    if (!ServersFound.ContainsKey(thisResult + ";" + (new CServiceType(CServiceType.VCenterServer)).ToString()))
                    {
                        CService s = new CService(thisResult, CServiceType.VCenterServer);
                        if (s.IP != null) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); }
                    }
                }
            }

            return ServersFound;
        }

        private Dictionary<string, CService> GetVCenterAppliancesUsingLikewise()
        {
            Dictionary<string, CService> ServersFound = new Dictionary<string, CService> { };
            SearchResultCollection QueryResult = null;
            QueryResult = QueryActiveDirectory(_DomainName, "(&(objectClass=Computer)(operatingSystemServicePack=Likewise Open unknown.unknown.unknown))", new List<string> { "dnshostname" });

            if (QueryResult != null)
            {
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult = QueryResult[i].Properties["dnshostname"][0].ToString();
                    if (!ServersFound.ContainsKey(thisResult + ";" + (new CServiceType(CServiceType.VCenterServer)).ToString()))
                    {
                        CService s = new CService(thisResult, CServiceType.VCenterServer);
                        if (s.IP != null) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); }
                    }
                }
            }

            return ServersFound;
        }

        private void DoPortScan(CService service, int port, CNetwork.Protocols protocol = null, string stringsearch = null)
        {
            using (TcpClient client = new TcpClient())
            {
                Log.Write(CFunctions.StringReplace("Checking " + protocol.ToString() + "://{0}:{1} for service presence ({2}).", CNetwork.IPToStringNz(service.IP), port.ToString(), stringsearch));
                var result = client.BeginConnect(service.IP, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(COptions.Connection_Timeout));
                bool found = false;
                if (success)
                {
                    if (protocol == CNetwork.Protocols.HTTP)
                    {
                        try
                        {
                            WebRequest req = HttpWebRequest.Create("http://" + service.Name);
                            req.Method = "GET";
                            using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                            {
                                while (!reader.EndOfStream && !found)
                                {
                                    string source = reader.ReadLine();
                                    if (source.ToLower().Contains(stringsearch.ToLower()))
                                    {
                                        found = true;
                                    }
                                }
                            }
                        }
                        catch { found = false; }
                    }
                    else { found = true; }

                    if (found)
                    {
                        lock (_ServerPortScanLock)
                        {
                            Log.Write("Service present (" + CNetwork.ProtocolToStringNz(protocol) + "): " + service.Name + " (" + service.Type + "); " + CNetwork.IPToStringNz(service.IP));
                            _ServerPortScanResults.Add(service.Name + ";" + service.Type.ToString() + ";" + CNetwork.IPToStringNz(service.IP) + ";" + port);
                        }
                    }
                }
            }
        }

        private Dictionary<string, CService> GetHyperVServers()
        {   
            SearchResultCollection QueryResult = null;
            Dictionary<string, CService> ServersFound = new Dictionary<string,CService> { };

            QueryResult = QueryActiveDirectory(_DomainName, "(&(objectClass=Computer)(servicePrincipalName=Hyper-V*))", new List<string> { "dnshostname" });

            if (QueryResult != null)
            {
                string log = ""; if (QueryResult.Count > 0) { log += "Hyper-V servers {"; }
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult = QueryResult[i].Properties["dnshostname"][0].ToString();
                    if (!ServersFound.ContainsKey(thisResult))
                    {
                        CService s = new CService(thisResult, CServiceType.HYVServer);
                        if (s.IP != null) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); log += s.Name + ", " + s.IP + "; "; }
                    }
                }
                Log.Write(log + "}", Log.Verbosity.Verbose);
            }

            return ServersFound;
        }

        private static List<CService> GetSCOMServers()
        {   // find SCVMM SPN in AD
            SearchResultCollection QueryResult = null;
            List<CService> ServersFound = new List<CService> { };

            QueryResult = QueryActiveDirectory(_DomainName, "(servicePrincipalName=MSOMHSvc*)", new List<string> { "dnshostname" });

            if (QueryResult != null)
            {
                // store previous results -- to avoid duplicate service connections
                string lastResult = "";

                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult = QueryResult[i].Properties["dnshostname"][0].ToString();
                    if (thisResult != lastResult)
                    {
                        CService service = new CService(thisResult, CServiceType.SCOMServer);
                        if(service.IP != null) { ServersFound.Add(service); }
                        lastResult = thisResult;
                    }
                }
            }
            return ServersFound;
        }

        private static Dictionary<string, CService> GetSCVMMServers()
        {   // find SCVMM SPN in AD
            SearchResultCollection QueryResult = null;
            Dictionary<string, CService> ServersFound = new Dictionary<string, CService> {};
            
            QueryResult = QueryActiveDirectory(_DomainName, "(&(cn=MSVMM)(objectClass=serviceConnectionPoint))", new List<string> { "servicednsname" });

            if (QueryResult != null)
            {
                // store previous results -- to avoid duplicate service connections
                string lastResult = "";
                string log = ""; if (QueryResult.Count > 0) { log += "SCVMM servers {";  }
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult = QueryResult[i].Properties["servicednsname"][0].ToString();
                    if (thisResult != lastResult)
                    {
                        CService s = new CService(thisResult, CServiceType.SCVMMServer);
                        if (s.IP != null) { ServersFound.Add(s.Name + ";" + s.Type.ToString(), s); log += s.Name + ", " + s.IP + "; "; }
                        lastResult = thisResult;
                    }
                }
                Log.Write(log + "}", Log.Verbosity.Verbose);
            }
            return ServersFound;
        }

        private static List<CService> GetPhysicalServers() // fetches all AD objects with "Windows Server" operating system, queries WMI to determine whether it's virtual or physical and its 'serial number' 
        {
            //SearchResultCollection QueryResult = null;
            List<CService> ServersFound = new List<CService> { };

            // does nothing right now

            return ServersFound;
        }

        private static List<CService> GetPhysicalWorkstations() // fetches all AD objects with "Windows Workstation" operating system, queries WMI to determine whether it's virtual or physical and its 'serial number' 
        {
            //SearchResultCollection QueryResult = null;
            List<CService> WorkstationsFound = new List<CService> { };

            // does nothing right now

            return WorkstationsFound;
        }

        private static SearchResultCollection QueryActiveDirectory(string location, string filter, List<string> properties)
        {
            SearchResultCollection result = null;

            try
            {
                DirectorySearcher search = new DirectorySearcher(new DirectoryEntry("LDAP://" + location)) { SearchScope = SearchScope.Subtree, Filter = filter };
                foreach (string p in properties)
                {
                    search.PropertiesToLoad.Add(p);
                }
                result = search.FindAll();
            }
            catch { /* failed query */ }

            return result;
        }

        public static string GetDomain()
        {
            // return NETBIOS domain suffix if joined (shorter method, official way is to use RootDSE but that is much slower)
            if (Environment.MachineName.ToLower() != Environment.UserDomainName.ToLower()) { return Environment.UserDomainName; }
            
            // else return null
            return null;
        }

        public Dictionary<string, CService> GetDomainServers()
        {
            SearchResultCollection QueryResult = null;
            Dictionary<string, CService> ServersFound = new Dictionary<string, CService> { };

            QueryResult = QueryActiveDirectory("OU=Domain Controllers," + rootDSE.Properties["defaultNamingContext"].Value.ToString(), "(objectClass=Computer)", new List<string> { "dnshostname" });

            if (QueryResult != null)
            {
                for (int i = 0; i < QueryResult.Count; i++)
                {
                    string thisResult = QueryResult[i].Properties["dnshostname"][0].ToString();
                    if (!ServersFound.ContainsKey(thisResult))
                    {
                        CService service = new CService(thisResult, CServiceType.DomainServer);
                        if (service.IP != null) { ServersFound.Add(thisResult, service); }
                    }
                }
            }

            return ServersFound;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {

            }
            // free native resources if there are any.  
            _DomainName = null;
        } 
    }
}
