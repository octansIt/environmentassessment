using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Common.VimApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace EnvironmentAssessment.Collector
{
    internal class VimSession : ISession
    {
        internal string SessionID;

        VimClient VIClient = null;
        UserSession VISession = null;
        
        internal List<CSite> _SiteInfo = new List<CSite> { };

        private Dictionary<string, string> ObjectUidCache;

        private Dictionary<string, Common.VimApi.HostSystem> HostCache;
        private object _HostCacheLock = new Object();

        private Dictionary<string, string> DatacenterCache;
        private Dictionary<string, string> ClusterCache;

        private Dictionary<string, HostNetworkSystem> HostNetworkSystemCache;
        private object _HostNetworkSystemCacheLock = new Object();
        
        private HashSet<string> FilesFoundCache;
        private object _FilesFoundCacheLock = new Object();

        //private HashSet<string> _VIMountPointCache;
        private Dictionary<string, CDiscoveredConfig> MountPointInfoCache;

        public VimSession(ref CService _Server)
        {
            Server = _Server;
        }

        public int Connect()
        {
            int result = 0;

            // make session ID equal to latest query id added, mostly for progress tracking purposes
            SessionID = Queries[Queries.Count - 1].Id;

            if (this.Error.Length > 0) // don't run if we experienced errors before
            { Completed = true; result = -1; return result; }

            if (!Connected)
            {
                Error = ""; // clear session err details           

                VISession = null;

                // try seeing if port is accessible
                Error = CNetwork.CheckPortStatus(Server.IP, VimClient.DefaultPort);

                if (Error.Length == 0)
                {
                    VIClient = new VimClient();

                    if ((Server.UserName.ToLower() == (Environment.UserDomainName + "\\" + Environment.UserName).ToLower()) && (Server.UserPassword.Length == 0)) { VISession = VIClient.LoginSSPI(this); }
                    else { VISession = VIClient.Login(this); } // otherwise use username and password

                    // check that we got a resulting session 
                    if (VISession != null) { if (VISession.LoginTime != null) { Server.Version = VIClient.ServiceContent.About.Version + " (" + VIClient.ServiceContent.About.Build + ")"; Connected = true; result = 0; } }
                    else { Completed = true; result = -1; }
                }

                //}
            }
            return result;
        }

        public void Disconnect()
        {
            if ((Server.Type == CServiceType.ESXServer) || (Server.Type == CServiceType.VCenterServer))
            {
                if (Connected == true)
                {
                    try { VIClient.Disconnect(); }
                    catch { } // do nothing right now if this fails
                    VISession = null;
                }
            }
            if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer))
            {
                // not doing anything yet
            }
        }

        internal List<CDiscoveredConfig> GetHosts(int queryid)
        {
            List<CDiscoveredConfig> HostsFound = new List<CDiscoveredConfig> { };

            // dont continue if not logged in
            if (VISession == null) { return HostsFound; }

            _SiteInfo = Server.Session.Queries[queryid].Sites;
            HostCache = new Dictionary<string, Common.VimApi.HostSystem> { };
            ClusterCache = GetClusterCache();
            DatacenterCache = GetDatacenterCache();

            IList<EntityViewBase> hosts = null;
            try { Log.Write("[VimApi] Querying hosts associated with " + Server.Name.ToUpper()); hosts = VIClient.FindEntityViews(typeof(HostSystem), null, null, new string[] { "name", "parent", "vm", "datastore", "runtime", "runtime", "configstatus", "configissue", "config.product", "configmanager.networksystem", "config.fileSystemVolume", "config.storageDevice", "hardware.cpuinfo", "hardware.memorysize", "hardware.systeminfo" }); }
            catch (Exception ex) { Log.Write("Error: Cannot query host system information. Details: " + ex.TargetSite + ex.Message); }
            if (hosts != null)
            {
                // change counter information to be more accurate as it may count empty objects
                // cache host queries
                Log.Write(CFunctions.StringReplace("Found hosts ({0}) associated with {1}", hosts.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in hosts)
                {
                    Common.VimApi.HostSystem host = null;
                    try { host = (Common.VimApi.HostSystem)tmp; }
                    catch { /* do nothing */ }
                    if (host != null)
                    {
                        lock (_HostCacheLock)
                        {
                            if ((host.Name != null) && !(HostCache.ContainsKey(host.MoRef.ToString())))
                            {
                                HostCache.Add(host.MoRef.ToString(), host);
                            }
                        }
                    }
                }

                lock (_HostCacheLock)
                {
                    foreach (Common.VimApi.HostSystem host in HostCache.Values)
                    {
                        if (host != null)
                        {
                            // get host ip address
                            System.Net.IPAddress ipaddr = null;
                            HostNetworkSystem hostnetwork = GetHostNetworkCached(host);
                            if (hostnetwork != null) { IPAddress.TryParse(hostnetwork.NetworkConfig.Vnic[0].Spec.Ip.IpAddress, out ipaddr); }

                            // get cluster and datacenter
                            string cluster = RetrieveCluster(host.Parent.ToString());
                            string datacenter = RetrieveDatacenter(host.Parent.ToString());

                            // get operating system
                            string os = null;
                            if (host.Config != null) { os = host.Config.Product.FullName; }


                            // get the rest of the details
                            CDiscoveredMetrics hostmetrics = new CDiscoveredMetrics();
                            hostmetrics.Set(CMetricType.HostCpu, CMetricSubtype.Sockets, host.Hardware.CpuInfo.NumCpuPackages);
                            hostmetrics.Set(CMetricType.HostCpu, CMetricSubtype.Cores, host.Hardware.CpuInfo.NumCpuCores);
                            hostmetrics.Set(CMetricType.HostMem, CMetricSubtype.Allocated, CFunctions.ConvertDataUnit(host.Hardware.MemorySize, CDataUnitType.Byte, CDataUnitType.MiB));
                            hostmetrics.Set(CMetricType.VmCount, CMetricSubtype.None, host.Vm.Count());
                            hostmetrics.Set(CMetricType.DsCount, CMetricSubtype.None, host.Datastore.Count());

                            CDiscoveredAttributes hostattribs = new CDiscoveredAttributes();
                            hostattribs.Set(CAttributeType.Reference, host.MoRef.ToString());
                            hostattribs.Set(CAttributeType.OS, os);
                            hostattribs.Set(CAttributeType.IP, ipaddr.ToStringNz());
                            hostattribs.Set(CAttributeType.HardwareVersion, (host.Hardware.SystemInfo.Vendor + " " + host.Hardware.SystemInfo.Model).Replace(",", String.Empty));
                            hostattribs.Set(CAttributeType.Cluster, cluster);
                            hostattribs.Set(CAttributeType.Datacenter, datacenter);

                            CDiscoveredAttributes stateattribs = new CDiscoveredAttributes();
                            hostattribs.Merge(GetObjectState(host));

                            CDiscoveredConfig hostinfo = new CDiscoveredConfig()
                            {
                                Type = new CDiscoveredTypes(CDiscoveredTypes.VIHost),
                                Site = CSite.Resolve(ipaddr, _SiteInfo),
                                Name = host.Name.ToString(),
                                Attributes = hostattribs,
                                Metrics = hostmetrics,
                                Owner = new List<string> { Server.Id },
                            };

                            if ((hosts.Count == 1) && (Server.Type == CServiceType.ESXServer)) { hostinfo.Id = Server.Id; }
                            StoreObjectUid(hostinfo.Attributes.Get(CAttributeType.Reference), hostinfo.Id);

                            Log.Write(hostinfo.ToString(), Log.Verbosity.Debug);

                            HostsFound.Add(hostinfo);
                        }
                    }
                }
            }

            HostsFound = HostsFound.OrderBy(o => o.Name).ToList(); // sort alphabetically
            return HostsFound;
        }

        private Dictionary<string, string> GetClusterCache()
        {
            Dictionary<string, string> results = new Dictionary<string, string> { };
            IList<EntityViewBase> clusters = null;
            try
            {
                Log.Write("[VimApi] Querying clusters associated with " + Server.Name.ToUpper());
                clusters = VIClient.FindEntityViews(typeof(ClusterComputeResource), null, null, new string[] { "name", "parent", "host" });
            }
            catch (Exception ex) { Log.Write("Error: Cannot query cluster information. Details: " + ex.TargetSite + ex.Message); }
            if (clusters != null)
            {
                Log.Write(CFunctions.StringReplace("Found clusters ({0}) associated with {1}", clusters.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in clusters)
                {
                    ClusterComputeResource cluster = null;
                    try { cluster = (ClusterComputeResource)tmp; }
                    catch { /* do nothing */ }
                    if (cluster != null)
                    {
                        if (cluster.Name != null)
                        {
                            foreach (ManagedObjectReference hostref in cluster.Host)
                            {
                                results.Add(hostref.ToString(), cluster.Name + ";" + cluster.Parent.ToString());
                            }
                            results.Add(cluster.MoRef.ToString(), cluster.Name + ";" + cluster.Parent.ToString());
                        }
                    }
                }
            }
            return results;
        }

        private Dictionary<string, string> GetDatacenterCache()
        {
            Dictionary<string, string> results = new Dictionary<string, string> { };
            IList<EntityViewBase> datacenters = null;
            try
            {
                Log.Write("[VimApi] Querying datacenters associated with " + Server.Name.ToUpper());
                datacenters = VIClient.FindEntityViews(typeof(Datacenter), null, null, new string[] { "name", "HostFolder" });
            }
            catch (Exception ex) { Log.Write("Error: Cannot query datacenter information. Details: " + ex.TargetSite + ex.Message); }
            if (datacenters != null)
            {
                Log.Write(CFunctions.StringReplace("Found datacenters ({0}) associated with {1}", datacenters.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in datacenters)
                {
                    Datacenter datacenter = null;
                    try { datacenter = (Datacenter)tmp; }
                    catch { /* do nothing */ }
                    if (datacenter != null)
                    {
                        if (datacenter.Name != null)
                        {
                            results.Add(datacenter.HostFolder.ToString(), datacenter.Name);
                        }
                    }
                }
            }
            return results;
        }


        private string RetrieveDatacenter(string p)
        {
            string result = "";
            string cluster = "";
            if (ClusterCache != null)
            {
                if (ClusterCache.TryGetValue(p, out cluster))
                {
                    string hostfolder = cluster.Split(';')[1];
                    DatacenterCache.TryGetValue(hostfolder, out result);
                }
            }
            return result;
        }

        private string RetrieveCluster(string p)
        {
            string result = "";
            string cluster = "";
            if (ClusterCache != null)
            {
                if (ClusterCache.TryGetValue(p, out cluster)) { result = cluster.Split(';')[0]; }
            }
            return result;
        }

        private HostNetworkSystem GetHostNetworkCached(Common.VimApi.HostSystem host)
        {
            if (host == null) { return null; }

            HostNetworkSystem networksystem = null;
            ManagedObjectReference nwref = host.ConfigManager.NetworkSystem;
            string key = nwref.ToString();

            lock (_HostNetworkSystemCacheLock)
            {
                // create cache if it does not exist
                if (HostNetworkSystemCache == null) { HostNetworkSystemCache = new Dictionary<string, HostNetworkSystem> { }; }
                // check for cache hit, only populate if not in cache
                if ((nwref != null) && !(HostNetworkSystemCache.ContainsKey(key)))
                {
                    networksystem = (HostNetworkSystem)VIClient.GetView(nwref, new string[] { "networkconfig" });
                    HostNetworkSystemCache.Add(key, networksystem);
                }
                else
                {
                    networksystem = HostNetworkSystemCache[key];
                }
            }

            if (networksystem.NetworkConfig != null) { return networksystem; }
            else { return null; }

        }

        internal List<CDiscoveredConfig> GetDatastores(int queryid)
        {
            List<CDiscoveredConfig> DatastoresFound = new List<CDiscoveredConfig> { };
            IList<EntityViewBase> datastores = null;

            _SiteInfo = Server.Session.Queries[queryid].Sites;
            //_VIMountPointCache = new HashSet<string> { };
            MountPointInfoCache = new Dictionary<string, CDiscoveredConfig> { };

            if (VIClient != null)
            {
                try { Log.Write("[VimApi] Querying datastores associated with " + Server.Name.ToUpper()); datastores = VIClient.FindEntityViews(typeof(Datastore), null, null, new string[] { "configissue", "configstatus", "host", "summary" }); }
                catch (Exception ex) { Log.Write("Error: Cannot query datastore information. Details: " + ex.TargetSite + ex.Message); }
                if (datastores != null)
                {
                    Log.Write("Found datastores (" + datastores.Count + ") associated with " + Server.Name.ToUpper());
                    foreach (EntityViewBase tmp in datastores)
                    {
                        Datastore ds = (Datastore)tmp;
                        
                        long storagealloc = CFunctions.ConvertDataUnit(ds.Summary.Capacity, CDataUnitType.Byte, CDataUnitType.MiB);
                        long storageused = CFunctions.ConvertDataUnit(ds.Summary.Capacity - ds.Summary.FreeSpace, CDataUnitType.Byte, CDataUnitType.MiB);

                        CDiscoveredConfig dsinfo = GetDatastoreMountInfo(queryid, ds);
                        
                        CDiscoveredMetrics dsmetric = new CDiscoveredMetrics();
                        dsmetric.Set(CMetricType.DsDisk, CMetricSubtype.Allocated, storagealloc);
                        dsmetric.Set(CMetricType.DsDisk, CMetricSubtype.Used, storageused );

                        dsinfo.Attributes.Set(CAttributeType.Reference, ds.MoRef.ToString());
                        dsinfo.Attributes.Set(CAttributeType.Format, ds.Summary.Type);
                        dsinfo.Attributes.Merge(GetObjectState(ds));

                        dsinfo.Type = new CDiscoveredTypes(CDiscoveredTypes.VIDatastore);
                        dsinfo.Name = ds.Summary.Name;
                        dsinfo.Metrics = dsmetric;
                        
                        StoreObjectUid(dsinfo.Attributes.Get(CAttributeType.Reference), dsinfo.Id);

                        Log.Write(dsinfo.ToString(), Log.Verbosity.Debug);

                        DatastoresFound.Add(dsinfo);
                    }
                }
                DatastoresFound = DatastoresFound.OrderBy(o => o.Name).ToList(); // sort alphabetically
            }
            return DatastoresFound;
        }

        private void QueryDatastore(int queryid, string FoldersToQuery, string[] MatchPattern = null)
        {
            // generate search spec
            HostDatastoreBrowserSearchSpec searchSpec = new HostDatastoreBrowserSearchSpec();
            FileQueryFlags detailQuery = new FileQueryFlags() { FileOwner = false, FileSize = true, FileType = true, Modification = false };
            VmDiskFileQuery diskQuery = new VmDiskFileQuery();
            VmDiskFileQueryFlags diskFlags = new VmDiskFileQueryFlags() { CapacityKb = true, DiskType = true, DiskExtents = false, ControllerType = false, HardwareVersion = false, Thin = false };
            diskQuery.Details = diskFlags;
            searchSpec.Query = new FileQuery[] { diskQuery };
            searchSpec.Details = detailQuery;
            searchSpec.MatchPattern = MatchPattern;

            string rootPath = "";
            string lastErrorPath = "";

            string[] folders = FoldersToQuery.Split(';');

            foreach (string path in folders)
            {
                if (path != null)
                {
                    string dsref = path.Split(',')[0];
                    string folder = path.Split(',')[1];
                    rootPath = folder.Split(']')[0] + "]";

                    Task searchTask = null;

                    if (rootPath != lastErrorPath) // only try each datastore once
                    {
                        ViewBase vw;
                        try
                        {
                            Log.Write(CFunctions.StringReplace("[VimApi] Querying {0} and sub folders for file information (matchpattern:" + String.Join(";", MatchPattern) + ").", folder), Log.Verbosity.Debug);
                            vw = VIClient.GetView(new ManagedObjectReference(dsref), null);
                        }
                        catch { vw = null; }

                        if (vw != null)
                        {
                            try
                            {
                                Datastore dsView = (Datastore)vw;
                                HostDatastoreBrowser dsBrowser = (HostDatastoreBrowser)VIClient.GetView((ManagedObjectReference)dsView.Browser, null);
                                ManagedObjectReference taskRef = (ManagedObjectReference)dsBrowser.SearchDatastoreSubFolders_Task(folder, searchSpec);
                                searchTask = (Task)VIClient.GetView(taskRef, new string[] { "info" });
                                while (searchTask.Info.State.ToString() == "running" || searchTask.Info.State.ToString() == "queued") { searchTask = (Task)VIClient.GetView(taskRef, new string[] { "info" }); }
                            }
                            catch { vw = null; }
                        }
                        if (vw == null)
                        {
                            Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot query datastore {0} information. This reduces reporting accuracy.", rootPath));
                            Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                            lastErrorPath = rootPath;
                        }
                    }

                    if (searchTask != null)
                    {
                        if (searchTask.Info.Result != null)
                        {
                            foreach (HostDatastoreBrowserSearchResults r in (HostDatastoreBrowserSearchResults[])searchTask.Info.Result)
                            {
                                foreach (FileInfo f in r.File)
                                {
                                    string ds = r.FolderPath + f.Path + "," + CFunctions.ConvertDataUnit(f.FileSize,CDataUnitType.Byte,CDataUnitType.MiB);
                                    StoreFilesFound(ds);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void StoreFilesFound(string ds)
        {
            lock (_FilesFoundCacheLock)
            {
                if (!FilesFoundCache.Contains(ds))
                {
                    Log.Write("  " + ds, Log.Verbosity.Everything);
                    FilesFoundCache.Add(ds);
                }
            }
        }

        private HashSet<string> QueryDatastores(int queryid, HashSet<string> FilesToQuery, string[] MatchPattern = null)
        {
            // enumerate list of unique folders to query
            List<string> FoldersToQuery = new List<string> { };
            FilesFoundCache = new HashSet<string> { };

            // generate match pattern
            if (MatchPattern == null) { MatchPattern = new string[] { "*.vmdk" }; }

            // remove duplicates
            foreach (string path in FilesToQuery)
            {
                string dsref = path.Split(',')[0];
                string folder = path.Split(',')[1].Split('/')[0];
                if (!FoldersToQuery.Contains(dsref + "," + folder)) { FoldersToQuery.Add(dsref + "," + folder); }
            }
            FoldersToQuery.Sort();

            List<string> DatastoreFoldersToQuery = new List<string> { };// using local context variable to allow delegation

            string rootPath = "";
            string lastRootPath = "";

            List<CThread> DatastoreQueries = new List<CThread> { };
            bool DatastoreQueryCompleted = false;

            for (int i = -1; i < FoldersToQuery.Count; i++) //intentional
            {
                if (i > -1) { rootPath = FoldersToQuery[i].Split(']')[0] + "]"; } // --> skip to bottom on first run
                // else (rootpath == lastrootpath)

                if ((rootPath != lastRootPath) || (i + 1 == FoldersToQuery.Count)) // query folders once datastore (root path) changes or at end of list
                {
                    // we have a new root path, create new query
                    // using new variable to spin-off thread
                    string dsFolderQuery = String.Join(";", DatastoreFoldersToQuery);
                    string[] m = MatchPattern;
                    int q = queryid;

                    string tid = CFunctions.GenerateUID();
                    Log.Write("Starting thread (" + tid + ") to run datastore query (query: " + q + ", folders: " + dsFolderQuery + ", matchpattern: " + String.Join(";", m) + ").", Log.Verbosity.Debug);

                    CThread query = new CThread() { Worker = new Thread(new ThreadStart(delegate () { QueryDatastore(q, dsFolderQuery, m); })), Id = tid };

                    DatastoreQueries.Add(query);
                    Core.ThreadManager.Add(query); // start thread when slots are available

                    // start over building
                    DatastoreFoldersToQuery = new List<string> { };
                }

                // --> bottom
                if (i < FoldersToQuery.Count - 1) { DatastoreFoldersToQuery.Add(FoldersToQuery[i + 1]); };
                lastRootPath = rootPath;
            }

            do // wait till completed
            {
                bool status = true;
                for (int i = 0; i < DatastoreQueries.Count; i++) { if (!DatastoreQueries[i].Completed) { status = false; } }
                DatastoreQueryCompleted = status;
                Thread.Sleep(COptions.Session_Thread_Wait);

            } while (!DatastoreQueryCompleted);

            return FilesFoundCache;
        }

        private CDiscoveredConfig GetDatastoreMountInfo(int queryid, Datastore ds) // needs to be rewritten and optimized
        {
            CDiscoveredConfig MountInfoFound = new CDiscoveredConfig {};
            MountInfoFound.Attributes = new CDiscoveredAttributes();

            string dsMountPath = null;

            // check input datastore value
            if (ds == null) { return MountInfoFound; } // give partial object
            if (ds.Summary != null) { if (ds.Summary.Url != null) { dsMountPath = ds.Summary.Url.Replace("ds://", "").TrimEnd('/'); } }
            if (dsMountPath == null)
            {
                Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. No summary data accessible.", ds.MoRef.ToString()));
                Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                return MountInfoFound; // give partial object;
            }

            // find out about mount point if not already done
            if (!MountPointInfoCache.ContainsKey(dsMountPath))
            {
                //string dsHostRef = null;
                //string dsHostName = "";
                Common.VimApi.HostSystem dsHost = null;
                IPAddress dsHostAddr = null;
                List<string> dsOwners = new List<string> { };

                for (int i = 0; i < ds.Host.Count(); i++)
                {
                    Common.VimApi.HostSystem h = GetHostCached(ds.Host[i].Key);
                    if (h != null)
                    {
                        dsOwners.Add(RetrieveObjectUid(h.MoRef.ToString()));
                        if ((dsHost == null) || (dsHost != null && (CompareObjectState(dsHost, h) > 0)))
                        {
                            dsHost = h;
                        }
                    }
                    else
                    {
                        Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Cannot get info from host with moref: {1}", ds.Summary.Name, ds.Host[i].Key.ToString()));
                        Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                    }
                }
                if (dsHost == null) { return MountInfoFound; /* give partial object */ }

                string dsHostCluster = RetrieveCluster(dsHost.Parent.ToString());
                string dsHostDatacenter = RetrieveDatacenter(dsHost.Parent.ToString());

                HostFileSystemMountInfo[] dsHostMountInfo = null;

                MountInfoFound.Owner = dsOwners;
                MountInfoFound.Attributes.Set(CAttributeType.Cluster, dsHostCluster);
                MountInfoFound.Attributes.Set(CAttributeType.Datacenter, dsHostDatacenter);

                try
                {
                    HostNetworkSystem hostnetwork = GetHostNetworkCached(dsHost);
                    if (hostnetwork != null) { IPAddress.TryParse(hostnetwork.NetworkConfig.Vnic[0].Spec.Ip.IpAddress, out dsHostAddr); }
                    dsHostMountInfo = dsHost.Config.FileSystemVolume.MountInfo;
                }
                catch
                {
                    Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Cannot get info from host {1} ({2})", ds.Summary.Name, dsHost.Name, dsHost.MoRef.ToString()));
                    Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                    return MountInfoFound; /* give up */
                }

                CSite dsHostSite = CSite.Resolve(dsHostAddr, _SiteInfo);
                MountInfoFound.Site = dsHostSite;

                for (int i = 0; i < dsHostMountInfo.Count(); i++)
                {
                    HostFileSystemMountInfo m = dsHostMountInfo[i];
                    if (m != null)
                    {
                        if (m.MountInfo != null)
                        {
                            if (m.MountInfo.Path != null)
                            {
                                if (m.MountInfo.Path.ToString() == dsMountPath) // we have a match 
                                {
                                    MountInfoFound.Attributes.Set(CAttributeType.Path, m.MountInfo.Path.ToString());
                                    MountInfoFound = GetDatastoreMountDetails(queryid, ds, dsHost, MountInfoFound, m);

                                    if (MountInfoFound != null)
                                    {
                                        MountPointInfoCache.Add(dsMountPath, MountInfoFound);
                                        i = dsHostMountInfo.Count(); //exit for
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // output mountpoint info
            MountPointInfoCache.TryGetValue(dsMountPath, out MountInfoFound);
            //if (MountPointInfoCache.ContainsKey(dsMountPath))
            //{
                MountInfoFound = MountPointInfoCache[dsMountPath];
                //string extents = String.Join(";", result.Children);
                //Log.Write("  " + result.Path + "," + result.Owner[0] + ",local:" + result.Local.ToString().ToLower() + "," + result.Mode + "," + result.Type + "," + extents + "," + result.Model + "," + result.Vendor + "," + result.Details, Log.Verbosity.Debug);
            //}

            return MountInfoFound;
        }

        private CDiscoveredConfig GetDatastoreMountDetails(int queryid, Datastore ds, Common.VimApi.HostSystem dsHost, CDiscoveredConfig mi, HostFileSystemMountInfo m)
        {
            if (m == null) { return mi; }
            
            mi.ChildInfo = new List<string> { };
            string accessMode = m.MountInfo.AccessMode;

            if (m.Volume is HostNasVolume)
            {
                HostNasVolume vol = (HostNasVolume)m.Volume;
                mi.Attributes.Set(CAttributeType.Local, "false");
                mi.Attributes.Set(CAttributeType.Mode, accessMode);
                mi.Attributes.Set(CAttributeType.Format, vol.Type);
                mi.Attributes.Set(CAttributeType.Details, vol.RemoteHost);
            }
            else if (m.Volume is HostVvolVolume)
            {
                HostVvolVolume vol = (HostVvolVolume)m.Volume;
                mi.Attributes.Set(CAttributeType.Local, "false");
                mi.Attributes.Set(CAttributeType.Mode, accessMode);
                mi.Attributes.Set(CAttributeType.Format, vol.Type);
            }
            else if (m.Volume is HostFileSystemVolume)
            {
                HostFileSystemVolume vol = (HostFileSystemVolume)m.Volume;
                mi.Attributes.Set(CAttributeType.Local, "false");
                mi.Attributes.Set(CAttributeType.Mode, accessMode);
                mi.Attributes.Set(CAttributeType.Format, vol.Type);
            }
            else if (m.Volume is HostVfatVolume)
            {
                HostVfatVolume vol = (HostVfatVolume)m.Volume;
                mi.Attributes.Set(CAttributeType.Local, "true");
                mi.Attributes.Set(CAttributeType.Mode, accessMode);
                mi.Attributes.Set(CAttributeType.Format, "VFatVolume");
            }
            else if (m.Volume is HostVmfsVolume)
            {
                HostVmfsVolume vol = (HostVmfsVolume)m.Volume;
                string diskType = vol.Type;
                bool volLocal = vol.Local.GetValueOrDefault(false);
                List<string> extents = new List<string> { };

                // only store once for now (will not be accurate for extents on non-similar storage) dont expect this to happen often
                string extentDiskModel = "";
                string extentDiskVendor = "";
                string extentDiskName = "";

                // get mount extents (luns)
                foreach (HostScsiDiskPartition ext in vol.Extent) { extents.Add(ext.DiskName); }

                // get information from first lun
                foreach (ScsiLun lun in dsHost.Config.StorageDevice.ScsiLun)
                {
                    for (int i = 0; i < extents.Count; i++) // get first valid extent only
                    {
                        if (extents[i].Contains(lun.CanonicalName))
                        {
                            extentDiskName = lun.DisplayName.Trim();
                            extentDiskModel = lun.Model.Trim();
                            extentDiskVendor = lun.Vendor.Trim().Replace(",", "");
                            i = extents.Count; // exit for
                        }
                    }
                }

                // rollup extents
                foreach (string extent in extents) { mi.ChildInfo.Add(extent); }

                // adding mountpoint info
                mi.Attributes.Set(CAttributeType.Local, volLocal.ToString());
                mi.Attributes.Set(CAttributeType.Mode, accessMode);
                mi.Attributes.Set(CAttributeType.Model, extentDiskModel);
                mi.Attributes.Set(CAttributeType.Vendor, extentDiskVendor);
                mi.Attributes.Set(CAttributeType.Details, extentDiskName);
                mi.Attributes.Set(CAttributeType.Format, diskType);

            }
            else
            {
                mi = null;
                string mountVolume = "";
                if (m.Volume != null) { mountVolume = m.Volume.GetType().ToString(); }

                Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Unsupported datastore type: {1}", ds.Summary.Name, mountVolume));
                Log.Write("Warning: " + Queries[queryid].Warnings.Last());

            }
            return mi;
        }

        private Common.VimApi.HostSystem GetHostCached(ManagedObjectReference hostref)
        {
            Common.VimApi.HostSystem host = null;
            lock (_HostCacheLock)
            {
                if ((hostref != null) && !(HostCache.ContainsKey(hostref.ToString())))
                {
                    try
                    {
                        host = (Common.VimApi.HostSystem)VIClient.GetView(hostref, new string[] { "name", "parent", "vm", "datastore", "runtime", "configissue", "configstatus", "config.product", "configmanager.networksystem", "config.fileSystemVolume", "config.storageDevice", "hardware.cpuinfo", "hardware.memorysize", "hardware.systeminfo" });
                    }
                    catch (VimException ex)
                    {
                        host = null;
                        Log.Write("Cannot query host information. Error: " + ex.TargetSite + ex.Message);
                    }
                    HostCache.Add(hostref.ToString(), host); // add null hosts to prevent multiple queries for references that resolve to nothing
                }
                else
                {
                    host = HostCache[hostref.ToString()];
                }
            }
            return host;
        }

        internal List<CDiscoveredConfig> GetVms(int queryid)
        {
            List<CDiscoveredConfig> VMsFound = new List<CDiscoveredConfig> { };

            // dont continue if not logged in
            if (VISession == null) { return VMsFound; }

            _SiteInfo = Server.Session.Queries[queryid].Sites;

            // get vm info
            IList<EntityViewBase> vms = null;
            try { Log.Write("[VimApi] Querying virtual machines associated with " + Server.Name.ToUpper()); vms = VIClient.FindEntityViews(typeof(VirtualMachine), null, null, new string[] { "parent", "configissue", "configstatus", "summary.storage", "summary.config", "config.name", "config.memoryallocation", "config.hardware", "config.version", "config.tools", "guest", "runtime", "layout.disk" }); }
            catch (Exception ex) { Log.Write("Error: Cannot query virtual machine information. Details: " + ex.TargetSite + ex.Message); }
            if (vms != null)
            {
                // iterate through vms and get general information
                Log.Write(CFunctions.StringReplace("Found virtual machines ({0}) associated with {1}", vms.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in vms)
                {
                    VirtualMachine vm = (VirtualMachine)tmp;

                    if (vm.Config.Name != null)
                    {
                        // zzz - eventually add parent name, this will change the search logic completely
                        // get ip address
                        IPAddress ipaddr = null;
                        if (vm.Guest.IpAddress != null) { IPAddress.TryParse(vm.Guest.IpAddress, out ipaddr); }

                        string cluster = RetrieveCluster(vm.Runtime.Host.ToString());
                        string datacenter = RetrieveDatacenter(vm.Runtime.Host.ToString());

                        string owner = "";
                        Common.VimApi.HostSystem host = GetHostCached(vm.Runtime.Host);
                        if (host != null) { owner = RetrieveObjectUid(host.MoRef.ToString()); }
                        
                        CDiscoveredMetrics guestusage = GetVmDiskUsage(queryid, vm);
                        guestusage.Set(CMetricType.VmCpu, CMetricSubtype.Sockets, vm.Config.Hardware.NumCPU);
                        guestusage.Set(CMetricType.VmCpu, CMetricSubtype.Cores, ((int)vm.Config.Hardware.NumCPU * vm.Config.Hardware.NumCoresPerSocket.GetValueOrDefault(1)));
                        guestusage.Set(CMetricType.VmMem, CMetricSubtype.Allocated, vm.Config.Hardware.MemoryMB);
                        
                        CDiscoveredAttributes guestattribs = new CDiscoveredAttributes();
                        guestattribs.Set(CAttributeType.Reference, vm.MoRef.ToString());
                        guestattribs.Set(CAttributeType.OS, vm.Summary.Config.GuestFullName);
                        guestattribs.Set(CAttributeType.IP, ipaddr.ToStringNz());
                        guestattribs.Set(CAttributeType.HardwareVersion, vm.Config.Version);
                        guestattribs.Set(CAttributeType.ToolsVersion, vm.Config.Tools.ToolsVersion.GetValueOrDefault(0).ToString());
                        guestattribs.Set(CAttributeType.Cluster, cluster);
                        guestattribs.Set(CAttributeType.Datacenter, datacenter);
                        guestattribs.Merge(GetObjectState(vm));

                        CDiscoveredConfig guestinfo = new CDiscoveredConfig
                        {
                            Type = new CDiscoveredTypes(CDiscoveredTypes.VIVM),
                            Site = CSite.Resolve(ipaddr, _SiteInfo),
                            Name = vm.Config.Name.ToString(),
                            Attributes = guestattribs,
                            Metrics = guestusage,
                            Owner = new List<string> { owner }
                        };

                        StoreObjectUid(guestinfo.Attributes.Get(CAttributeType.Reference), guestinfo.Id);
                        guestinfo.ChildObjects = GetVmDisks(queryid, vm);

                        Log.Write(guestinfo.ToString(), Log.Verbosity.Debug);

                        VMsFound.Add(guestinfo);
                    }
                }

                VMsFound = VMsFound.OrderBy(o => o.Name).ToList(); // sort alphabetically

                // need to improve this in the future where either we use the integration tools
                // if that does not work, use datastore information for thin disks (UpdateVmDiskDatastoreInfo)
                // and if that does not work use the summary object.
                VMsFound = UpdateVmDiskDatastoreInfo(queryid, VMsFound);
            }

            return VMsFound;
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

        private CDiscoveredAttributes GetObjectState(EntityViewBase obj)
        {
            CDiscoveredAttributes result = new CDiscoveredAttributes();
            if (obj.GetType().ToString().Contains("VirtualMachine"))
            {
                VirtualMachine vm = (VirtualMachine)obj;
                string issues = "";
                foreach (Event e in vm.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result.Set(CAttributeType.PowerState, vm.Runtime.PowerState.ToString());
                result.Set(CAttributeType.ConfigState, vm.ConfigStatus.ToString());
                result.Set(CAttributeType.ConfigIssues, issues);
                result.Set(CAttributeType.ConnectionState, vm.Runtime.ConnectionState.ToString());
            }
            else if (obj.GetType().ToString().Contains("HostSystem"))
            {
                Common.VimApi.HostSystem host = (Common.VimApi.HostSystem)obj;
                string issues = "";
                foreach (Event e in host.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result.Set(CAttributeType.PowerState, host.Runtime.PowerState.ToString());
                result.Set(CAttributeType.ConfigState, host.ConfigStatus.ToString());
                result.Set(CAttributeType.ConfigIssues, issues);
                result.Set(CAttributeType.ConnectionState, host.Runtime.ConnectionState.ToString());
            }
            else if (obj.GetType().ToString().Contains("Datastore"))
            {
                Datastore ds = (Datastore)obj;
                string issues = "";
                foreach (Event e in ds.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result.Set(CAttributeType.ConfigState, ds.ConfigStatus.ToString());
                result.Set(CAttributeType.ConfigIssues, issues);
            }
            return result;
        }

        private int GetObjectConfigStatus(EntityViewBase obj)
        {
            int result = 0;
            if (obj.GetType().ToString().Contains("VirtualMachine"))
            {
                VirtualMachine vm = (VirtualMachine)obj;
                result = (int)vm.ConfigStatus;
            }
            else if (obj.GetType().ToString().Contains("HostSystem"))
            {
                Common.VimApi.HostSystem host = (Common.VimApi.HostSystem)obj;
                result = (int)host.ConfigStatus;
            }
            else if (obj.GetType().ToString().Contains("Datastore"))
            {
                Datastore ds = (Datastore)obj;
                result = (int)ds.ConfigStatus;
            }
            return result;
        }

        private int CompareObjectState(EntityViewBase obj1, EntityViewBase obj2)
        {
            int result = 0;
            int s1 = GetObjectConfigStatus(obj1);
            int s2 = GetObjectConfigStatus(obj2);
            if (s1 < s2)
            {
                result = -1;
            }
            else if (s1 > s2)
            {
                result = 1;
            }
            return result;
        }

        private CDiscoveredMetrics GetVmDiskUsage(int queryid, VirtualMachine vm)
        {
            CDiscoveredMetrics DiscoveredMetrics = new CDiscoveredMetrics();

            double vmSwapfileUsage = 0;
            if (vm.Runtime.PowerState.ToString() == "poweredOn") { vmSwapfileUsage = vm.Config.Hardware.MemoryMB - Convert.ToInt32(vm.Config.MemoryAllocation.Reservation); }

            // need to improve this in the future where either we use the integration tools
            // if that does not work, use datastore information for thin disks (UpdateVmDiskDatastoreInfo)
            // and if that does not work use the summary object.

            if (vm.Guest.Disk != null) // get vm disk information from integration tools
            {
                foreach (GuestDiskInfo disk in vm.Guest.Disk)
                {
                    DiscoveredMetrics.Increment(CMetricType.VmDisk, CMetricSubtype.Allocated, CFunctions.ConvertDataUnit(disk.Capacity.Value,CDataUnitType.Byte,CDataUnitType.MiB));
                    DiscoveredMetrics.Increment(CMetricType.VmDisk, CMetricSubtype.Used, CFunctions.ConvertDataUnit(disk.Capacity.Value - disk.FreeSpace.Value,CDataUnitType.Byte,CDataUnitType.MiB));
                }
            }
            else // get vm disk information from summary object
            {
                
                double allocated = CFunctions.ConvertDataUnit(vm.Summary.Storage.Committed + vm.Summary.Storage.Uncommitted, CDataUnitType.Byte, CDataUnitType.MiB);
                double used = CFunctions.ConvertDataUnit(vm.Summary.Storage.Committed, CDataUnitType.Byte, CDataUnitType.MiB);
                if (vmSwapfileUsage > 0)
                {
                    if ((allocated - vmSwapfileUsage) > 0) { allocated -= vmSwapfileUsage; }
                    if ((used - vmSwapfileUsage) > 0) { used -= vmSwapfileUsage; }  
                }

                DiscoveredMetrics.Set(CMetricType.VmDisk, CMetricSubtype.Allocated, (long)allocated);
                DiscoveredMetrics.Set(CMetricType.VmDisk, CMetricSubtype.Used, (long)used);
            }

            // no way to tell unshared memory from integration tools 
            // so always use this method
            double unshared = CFunctions.ConvertDataUnit(vm.Summary.Storage.Unshared,CDataUnitType.Byte,CDataUnitType.MiB);
            if (vmSwapfileUsage > 0)
            {
                if ((unshared - vmSwapfileUsage) > 0) { unshared -= vmSwapfileUsage; }
            }
            DiscoveredMetrics.Set(CMetricType.VmDisk, CMetricSubtype.Unshared, (long)unshared);

            return DiscoveredMetrics;
        }

        private List<CDiscoveredConfig> GetVmDisks(int queryid, VirtualMachine vm)
        {
            List<CDiscoveredConfig> DisksFound = new List<CDiscoveredConfig> { };

            // validate vm object
            if ((vm.Config.Hardware.Device == null) || (vm.Layout.Disk == null)) { return DisksFound; } // don't continue if we don't have hardware information or disk layout information

            // get disk parent info
            List<VirtualDevice> vmdisks = new List<VirtualDevice> { };
            foreach (VirtualDevice device in vm.Config.Hardware.Device) { if (device != null) { if (device is VirtualDisk) { vmdisks.Add(device); } } } // get disk info 
            if (vmdisks.Count == 0) { return DisksFound; } // don't continue if no disks are found.

            foreach (VirtualDisk disk in vmdisks)
            {
                VirtualDeviceBackingInfo backinginfo = disk.Backing;
                object dsref = null, mode = null;
                bool thin = false;
                string path = null, name = null;
                
                if (backinginfo != null)
                {
                    foreach (var p in backinginfo.GetType().GetProperties())
                    {
                        if (p.Name == "ThinProvisioned")
                        {
                            thin = ((bool?)p.GetValue(backinginfo, null)).GetValueOrDefault(false);
                        }
                        if (p.Name == "FileName") { path = p.GetValue(backinginfo, null).ToString(); }
                        if (p.Name == "Datastore") { dsref = p.GetValue(backinginfo, null); }
                        if (p.Name == "DiskMode") { mode = p.GetValue(backinginfo, null); }
                    }
                    if (path != null)
                    {
                        name = path.Split(']')[1].Trim();
                        if (name.Contains('/')) { name = name.Substring(name.LastIndexOf('/') + 1); } // get filename by itself

                        string parent = RetrieveObjectUid(vm.MoRef.ToString());

                        // set VM size info, and if not thin make these the same
                        long allocated = CFunctions.ConvertDataUnit(disk.CapacityInKB, CDataUnitType.KiB, CDataUnitType.MiB);
                        long used = 0;
                        if (!thin) { used = allocated; }

                        CDiscoveredMetrics diskusage = new CDiscoveredMetrics();
                        diskusage.Set(CMetricType.VmDisk, CMetricSubtype.Allocated, allocated);
                        diskusage.Set(CMetricType.VmDisk, CMetricSubtype.Used, used);
                        CDiscoveredAttributes diskattribs = new CDiscoveredAttributes();
                        diskattribs.Set(CAttributeType.Path, path);
                        diskattribs.Set(CAttributeType.Reference, dsref.ToStringNz());
                        diskattribs.Set(CAttributeType.Thin, thin.ToString());
                        diskattribs.Set(CAttributeType.Mode, mode.ToStringNz());
                        DisksFound.Add(new CDiscoveredConfig() { Name = name, Attributes = diskattribs, Metrics = diskusage, Type = CDiscoveredTypes.VIDisk, Owner = new List<string> { parent } } );
                    }
                }
            }
            vmdisks = null;

            // get disk children (ie parts of parent VMDK) zzz - deprecated, should use LayoutEx instead
            foreach (VirtualMachineFileLayoutDiskLayout disklayout in vm.Layout.Disk)
            {
                if (disklayout.DiskFile != null)
                {
                    foreach (string diskchild in disklayout.DiskFile)
                    {
                        int loc = -1;
                        for (int i = 0; i < DisksFound.Count; i++)
                        {
                            string name = DisksFound[i].Name.Replace(".vmdk", ""); // remove trailing .vmdk

                            if (name.LastIndexOf('-') > 0)
                            { // check if we have differencing (-00000*) disk, get parent name instead
                                string idx = name.Substring(name.LastIndexOf('-') + 1);
                                if (idx.Length == 6)
                                {
                                    int n;
                                    if (Int32.TryParse(idx, out n)) { name = name.Substring(0, name.LastIndexOf('-')); /* name = parentname */ }
                                }
                            }
                            if (diskchild.Contains(name + ".vmdk") || (diskchild.Contains(name + "-"))) /* exact match or differencing disk */ { loc = i; i = DisksFound.Count; /* exit loop */ }

                        }
                        if (loc != -1) {
                            if (DisksFound[loc].ChildInfo == null) { DisksFound[loc].ChildInfo = new List<string> { }; }
                            DisksFound[loc].ChildInfo.Add(diskchild); }
                        else
                        {
                            /* no parent disk found -- add it as new parent */
                            string rootPath = diskchild.Split(']')[0].Replace("[", "").Trim();
                            string dsRef = DisksFound[0].Attributes.Get(CAttributeType.Reference); // revert to default datastore if nothing is found (cheating -- I know, but remember we're searching a list of already known datastores and files so we should be safe)
                            string name = diskchild.Split(']')[1].Trim();
                            if (name.Contains('/')) { name = name.Substring(name.LastIndexOf('/') + 1); } // get filename by itself
                            for (int i = 0; i < DisksFound.Count; i++) // get datastore reference if we already have one
                            {
                                if (DisksFound[i].Attributes.Get(CAttributeType.Path).Contains(rootPath)) { dsRef = DisksFound[i].Attributes.Get(CAttributeType.Reference); i = DisksFound.Count; }
                            }
                            CDiscoveredMetrics diskmetrics = new CDiscoveredMetrics(CMetricType.VmDisk, CMetricSubtype.Used, 0);
                            CDiscoveredAttributes diskattribs = new CDiscoveredAttributes();
                            diskattribs.Set(CAttributeType.Path, diskchild);
                            diskattribs.Set(CAttributeType.Thin, "true");
                            diskattribs.Set(CAttributeType.Reference, dsRef);
                            DisksFound.Add(new CDiscoveredConfig() { Name = name, Attributes = diskattribs, Metrics = diskmetrics });
                            if (DisksFound[DisksFound.Count - 1].ChildInfo == null) { DisksFound[DisksFound.Count - 1].ChildInfo = new List<string> { }; }
                            DisksFound[DisksFound.Count - 1].ChildInfo.Add(diskchild);
                        }
                    }
                }
            }

            return DisksFound;

        }

        private List<CDiscoveredConfig> UpdateVmDiskDatastoreInfo(int queryid, List<CDiscoveredConfig> vms) // issue with math here
        {
            HashSet<string> FilesToQuery = new HashSet<string> { };
            HashSet<string> QueryResults = new HashSet<string> { };

            if (COptions.Preciseness == COptions.Precision.High)
            {
                Log.Write("Getting details for thin provisioned VMs. This queries the datastore for information per folder for each VM in question.", Log.Verbosity.Verbose);

                // organize data for query
                for (int i = 0; i < vms.Count; i++)
                {
                    if ((vms[i].ChildObjects) != null)
                    {
                        for (int j = 0; j < vms[i].ChildObjects.Count; j++)
                        {
                            CDiscoveredConfig disk = vms[i].ChildObjects[j];
                            if (disk.Attributes.Get(CAttributeType.Thin) == "true")
                            { // depends on compile-time constant
                              // need to update logic to detect if _DSRef refers to a VSAN datastore at which point it is better to use VI_Datastore_Search_Level = 1
                                if (COptions.VI_Datastore_Search_Level == 0) { string fq = disk.Attributes.Get(CAttributeType.Reference) + "," + disk.Attributes.Get(CAttributeType.Path).Split(']')[0] + "]"; if (!FilesToQuery.Contains(fq)) { FilesToQuery.Add(fq); } }
                                else if (COptions.VI_Datastore_Search_Level == 1) { string fq = disk.Attributes.Get(CAttributeType.Reference) + "," + disk.Attributes.Get(CAttributeType.Path); if (!FilesToQuery.Contains(fq)) { FilesToQuery.Add(fq); } }
                            }
                        }
                    }
                }

                // clear data from array             
                foreach (string dsfile in QueryResults)
                {
                    string dsfilepath = dsfile.Split(',')[0];
                    string dsfilesize = dsfile.Split(',')[1];
                    for (int i = 0; i < vms.Count; i++)
                    {
                        for (int j = 0; j < vms[i].ChildObjects.Count; j++)
                        {
                            if (vms[i].ChildObjects[j].Attributes.Get(CAttributeType.Path) == dsfilepath)
                            {
                                vms[i].ChildObjects[j].Metrics.Set(CMetricType.VmDisk, CMetricSubtype.Used, 0); // found disk, clear incorrect "approximate data" from vSphere                        
                            }
                        }
                    }
                }

                QueryResults = QueryDatastores(queryid, FilesToQuery);

                // put data back into array
                foreach (string dsfile in QueryResults)
                {
                    string dsfilepath = dsfile.Split(',')[0];
                    string dsfilesize = dsfile.Split(',')[1];

                    for (int i = 0; i < vms.Count; i++)
                    {
                        for (int j = 0; j < vms[i].ChildObjects.Count; j++)
                        {
                            for (int k = 0; k < vms[i].ChildObjects[j].ChildInfo.Count(); k++)
                            {
                                if (vms[i].ChildObjects[j].ChildInfo[k] == dsfilepath)
                                {
                                    vms[i].ChildObjects[j].Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Used, (Int64)Math.Round(Double.Parse(dsfilesize), MidpointRounding.AwayFromZero));
                                    vms[i].ChildObjects[j].ChildInfo[k] += "," + Double.Parse(dsfilesize); // append file size to child name
                                }
                            }
                        }
                    }
                }

                // update 'actual' datastore usage
                Int64[] diskusageactual = new Int64[] { 0, 0 };
                for (int i = 0; i < vms.Count; i++)
                {
                    for (int j = 0; j < vms[i].ChildObjects.Count; j++)
                    {
                        vms[i].Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Allocated, vms[i].ChildObjects[j]);
                        vms[i].Metrics.Increment(CMetricType.VmDisk, CMetricSubtype.Used, vms[i].ChildObjects[j]);
                    }
                }
            }

            // output results
            /* if (COptions.Verbosity >= Log.Verbosity.Debug)
            {
                foreach (CDiscoveredConfig vm in vms)
                {
                    Log.Write(CFunctions.StringReplace("Found disks ({0}) associated with {1}", vm.Disks.Count.ToString(), vm.Name.ToUpper()), Log.Verbosity.Debug);
                    foreach (CDiscoveredConfig disk in vm.Disks)
                    {
                        // path, total, used, thick/thin
                        string output = CFunctions.StringReplace("  {0},allocated:{1} (MB),used:{2} (MB),thin:{3},(disk parts:", disk.Path, disk.Metrics.Get(CMetricType.VmDisk, CMetricSubtype.Allocated).ToString(), disk.Metrics.Get(CMetricType.VmDisk, CMetricSubtype.Used).ToString(), disk.Metrics.Get(CMetricType.VmDisk, CMetricSubtype.Thin).ToString().ToLower());
                        output += String.Join(";", disk.Children);
                        Log.Write(output + ")", Log.Verbosity.Debug);
                    }
                }
            } */

            return vms;
        }
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected new virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // do nothing yet
                if (VIClient != null) { VIClient.Dispose(); VIClient = null; }
            }
            
            if (HostCache != null) { HostCache.Clear(); HostCache = null; }
            if (HostNetworkSystemCache != null) { HostNetworkSystemCache.Clear(); HostNetworkSystemCache = null; }

            if (DatacenterCache != null) { DatacenterCache.Clear(); DatacenterCache = null; }
            if (ClusterCache != null) { ClusterCache.Clear(); ClusterCache= null; }

            //if (_VIMountPointCache != null) { _VIMountPointCache.Clear(); _VIMountPointCache = null; }
            if (MountPointInfoCache != null) { MountPointInfoCache.Clear(); MountPointInfoCache = null; }

            if (FilesFoundCache != null) { FilesFoundCache.Clear(); FilesFoundCache = null; }

            _HostCacheLock = null;
            _HostNetworkSystemCacheLock = null;
        }
    }
}
