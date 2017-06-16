using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;
using EnvironmentAssessment.Common.VISoap;
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

        private Dictionary<string, Common.VISoap.HostSystem> _VIHosts;
        private object _VIHostCacheLock = new Object();
        private Dictionary<string, HostNetworkSystem> _VIHostNetworkSystem;
        private object _VIHostNetworkSystemCacheLock = new Object();
        private Dictionary<string, string> _VIDatacenters;
        private Dictionary<string, string> _VIClusters;
        private HashSet<string> _VIFilesFoundCache;
        private object _VIFilesFoundCacheLock = new Object();
        private HashSet<string> _VIMountPoints;
        private Dictionary<string, CStorageConfig> _VIMountPointInfo;

        public VimSession(ref CService _Server)
        {
            Server = _Server;
        }

        public int Connect()
        {
            int result = 0;

            // make session ID equal to latest query id added, mostly for progress tracking purposes
            SessionID = Queries[Queries.Count - 1].ID;

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
                    _VIHosts = new Dictionary<string, Common.VISoap.HostSystem> { };
                    _VIHostNetworkSystem = new Dictionary<string, HostNetworkSystem> { };
                    _VIDatacenters = new Dictionary<string, string> { };
                    _VIClusters = new Dictionary<string, string> { };
                    _VIFilesFoundCache = new HashSet<string> { };
                    _VIMountPoints = new HashSet<string> { };
                    _VIMountPointInfo = new Dictionary<string, CStorageConfig> { };

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

        internal List<CServiceConfig> GetVIHosts(int queryid)
        {
            List<CServiceConfig> HostsFound = new List<CServiceConfig> { };

            // dont continue if not logged in
            if (VISession == null) { return HostsFound; }

            IList<EntityViewBase> clusters = null;
            try
            {
                Log.Write("[ViSoap] Querying clusters assocated with " + Server.Name.ToUpper());
                clusters = VIClient.FindEntityViews(typeof(ClusterComputeResource), null, null, new string[] { "name", "parent", "host" });
            }
            catch (Exception ex) { Log.Write("Cannot query cluster information. Error: " + ex.TargetSite + ex.Message); }
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
                                _VIClusters.Add(hostref.ToString(), cluster.Name + ";" + cluster.Parent.ToString());
                            }
                            _VIClusters.Add(cluster.MoRef.ToString(), cluster.Name + ";" + cluster.Parent.ToString());
                        }
                    }
                }
            }

            IList<EntityViewBase> datacenters = null;
            try
            {
                Log.Write("[ViSoap] Querying datacenters assocated with " + Server.Name.ToUpper());
                datacenters = VIClient.FindEntityViews(typeof(Datacenter), null, null, new string[] { "name", "HostFolder" });
            }
            catch (Exception ex) { Log.Write("Cannot query datacenter information. Error: " + ex.TargetSite + ex.Message); }
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
                            _VIDatacenters.Add(datacenter.HostFolder.ToString(), datacenter.Name);
                        }
                    }
                }
            }

            IList<EntityViewBase> hosts = null;
            try { Log.Write("[ViSoap] Querying hosts associated with " + Server.Name.ToUpper()); hosts = VIClient.FindEntityViews(typeof(Common.VISoap.HostSystem), null, null, new string[] { "name", "parent", "vm", "datastore", "runtime", "runtime", "configstatus", "configissue", "config.product", "configmanager.networksystem", "config.fileSystemVolume", "config.storageDevice", "hardware.cpuinfo", "hardware.memorysize", "hardware.systeminfo" }); }
            catch (Exception ex) { Log.Write("Cannot query host system information. Error: " + ex.TargetSite + ex.Message); }
            if (hosts != null)
            {
                // change counter information to be more accurate as it may count empty objects
                // cache host queries
                Log.Write(CFunctions.StringReplace("Found hosts ({0}) associated with {1}", hosts.Count.ToString(), Server.Name.ToUpper()));
                foreach (EntityViewBase tmp in hosts)
                {
                    Common.VISoap.HostSystem host = null;
                    try { host = (Common.VISoap.HostSystem)tmp; }
                    catch { /* do nothing */ }
                    if (host != null)
                    {
                        lock (_VIHostCacheLock)
                        {
                            if ((host.Name != null) && !(_VIHosts.ContainsKey(host.MoRef.ToString())))
                            {
                                _VIHosts.Add(host.MoRef.ToString(), host);
                            }
                        }
                    }
                }

                lock (_VIHostCacheLock)
                {
                    foreach (Common.VISoap.HostSystem host in _VIHosts.Values)
                    {
                        if (host != null)
                        {
                            // get host ip address
                            System.Net.IPAddress ipaddr = null;
                            HostNetworkSystem hostnetwork = GetVIHostNetworkCached(host);
                            if (hostnetwork != null) { IPAddress.TryParse(hostnetwork.NetworkConfig.Vnic[0].Spec.Ip.IpAddress, out ipaddr); }

                            // get cluster and datacenter
                            string cluster = GetVICluster(host.Parent.ToString());
                            string datacenter = GetVIDatacenter(host.Parent.ToString());

                            // get operating system
                            string os = null;
                            if (host.Config != null) { os = host.Config.Product.FullName; }

                            // get the rest of the details
                            CServiceConfig hostinfo = new CServiceConfig()
                            {
                                Site = CSite.Resolve(ipaddr, _SiteInfo),
                                Name = host.Name.ToString(),
                                IP = ipaddr,
                                OS = os,
                                CPUSockets = host.Hardware.CpuInfo.NumCpuPackages,
                                CPUCores = host.Hardware.CpuInfo.NumCpuCores,
                                RAM = (Int64)Math.Round((host.Hardware.MemorySize / Math.Pow(1024, 2)), MidpointRounding.AwayFromZero),
                                _HardwareVersion = (host.Hardware.SystemInfo.Vendor + " " + host.Hardware.SystemInfo.Model).Replace(",", String.Empty),
                                State = GetVIObjectState(host),
                                Cluster = cluster,
                                Datacenter = datacenter,
                                Children = new List<string> { host.Vm.Count().ToString(), host.Datastore.Count().ToString() }
                            };

                            string logdata = "  ";
                            if (hostinfo.Site != null) { logdata = hostinfo.Site.Name + ","; }
                            if (hostinfo.Datacenter.Length > 0) { logdata += hostinfo.Datacenter + ","; }
                            if (hostinfo.Cluster.Length > 0) { logdata += hostinfo.Cluster + ","; }

                            logdata += hostinfo.Name + "," + hostinfo.IP + "," + hostinfo.OS + "," + hostinfo.CPUSockets + " (" + hostinfo.CPUCores + " cores),memory:" + hostinfo.RAM + " (MB)," + hostinfo._HardwareVersion;
                            Log.Write(logdata, Log.Verbosity.Debug);

                            HostsFound.Add(hostinfo);
                        }
                    }
                }
            }

            HostsFound = HostsFound.OrderBy(o => o.Name).ToList(); // sort alphabetically
            return HostsFound;
        }

        private HostNetworkSystem GetVIHostNetworkCached(Common.VISoap.HostSystem host)
        {
            if (host == null) { return null; }

            HostNetworkSystem networksystem = null;
            ManagedObjectReference nwref = host.ConfigManager.NetworkSystem;
            string key = nwref.ToString();

            lock (_VIHostNetworkSystemCacheLock)
            {
                if ((nwref != null) && !(_VIHostNetworkSystem.ContainsKey(key))) // check for cache hit, only populate if not in cache
                {
                    networksystem = (HostNetworkSystem)VIClient.GetView(nwref, new string[] { "networkconfig" });
                    _VIHostNetworkSystem.Add(key, networksystem);
                }
                else
                {
                    networksystem = _VIHostNetworkSystem[key];
                }
            }

            if (networksystem.NetworkConfig != null) { return networksystem; }
            else { return null; }

        }

        private string GetVIDatacenter(string p)
        {
            string result = "";
            if (_VIClusters.ContainsKey(p))
            {
                string hostfolder = _VIClusters[p].Split(';')[1];
                if (_VIDatacenters.ContainsKey(hostfolder)) { result = _VIDatacenters[hostfolder]; }
            }
            return result;
        }

        private string GetVICluster(string p)
        {
            string result = "";
            if (_VIClusters.ContainsKey(p)) { result = _VIClusters[p].Split(';')[0]; }
            return result;
        }

        internal List<CStorageConfig> GetVIDatastores(int queryid)
        {
            List<CStorageConfig> DatastoresFound = new List<CStorageConfig> { };
            IList<EntityViewBase> datastores = null;

            if (VIClient != null)
            {
                try { Log.Write("[ViSoap] Querying datastores associated with " + Server.Name.ToUpper()); datastores = VIClient.FindEntityViews(typeof(Datastore), null, null, new string[] { "configissue", "configstatus", "host", "summary" }); }
                catch (Exception ex) { Log.Write("Cannot query datastore information. Error: " + ex.TargetSite + ex.Message); }
                if (datastores != null)
                {
                    Log.Write("Found datastores (" + datastores.Count + ") associated with " + Server.Name.ToUpper());
                    foreach (EntityViewBase tmp in datastores)
                    {
                        Datastore ds = (Datastore)tmp;
                        long storagealloc = (Int64)Math.Round(ds.Summary.Capacity / Math.Pow(1024, 2), MidpointRounding.AwayFromZero);
                        long storageused = (Int64)Math.Round((ds.Summary.Capacity / Math.Pow(1024, 2)) - (ds.Summary.FreeSpace / Math.Pow(1024, 2)), MidpointRounding.AwayFromZero);
                        CStorageConfig dsinfo;

                        using (CStorageConfig _dsmountinfo = GetVIDatastoreMountInfo(queryid, ds))
                        {
                            if (_dsmountinfo != null) { dsinfo = _dsmountinfo; }
                            else { dsinfo = new CStorageConfig(); dsinfo.Cluster = ""; dsinfo.Datacenter = ""; }
                        }

                        dsinfo.Name = ds.Summary.Name;
                        dsinfo.Allocated = storagealloc;
                        dsinfo.Used = storageused;
                        dsinfo.Type = ds.Summary.Type;
                        dsinfo.State = GetVIObjectState(ds);
                        string logdata = "  ";
                        if (dsinfo.Site != null) { logdata = dsinfo.Site.Name + ","; }

                        logdata += dsinfo.Name.ToUpper() + "," + dsinfo.FullPath + ",allocated:" + dsinfo.Allocated + " (MB) used:" + dsinfo.Used + " (MB)," + dsinfo.Model + "," + dsinfo.Vendor;
                        Log.Write(logdata, Log.Verbosity.Debug);

                        DatastoresFound.Add(dsinfo);
                    }
                }
                DatastoresFound = DatastoresFound.OrderBy(o => o.Name).ToList(); // sort alphabetically
            }
            return DatastoresFound;
        }

        private void QueryVIDatastore(int queryid, string FoldersToQuery, string[] MatchPattern = null)
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
                            Log.Write(CFunctions.StringReplace("[ViSoap] Querying {0} and sub folders for file information (matchpattern:" + String.Join(";", MatchPattern) + ").", folder), Log.Verbosity.Debug);
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
                                    string ds = r.FolderPath + f.Path + "," + f.FileSize / Math.Pow(1024, 2);
                                    lock (_VIFilesFoundCacheLock)
                                    {
                                        if (!_VIFilesFoundCache.Contains(ds))
                                        {
                                            Log.Write("  " + ds, Log.Verbosity.Everything);
                                            _VIFilesFoundCache.Add(ds);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private HashSet<string> QueryVIDatastores(int queryid, HashSet<string> FilesToQuery, string[] MatchPattern = null)
        {
            // enumerate list of unique folders to query
            List<string> FoldersToQuery = new List<string> { };
            _VIFilesFoundCache = new HashSet<string> { };

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

                    CThread query = new CThread() { Worker = new Thread(new ThreadStart(delegate () { QueryVIDatastore(q, dsFolderQuery, m); })), ID = tid };

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

            return _VIFilesFoundCache;
        }

        private CStorageConfig GetVIDatastoreMountInfo(int queryid, Datastore ds) // needs to be rewritten and optimized
        {
            CStorageConfig result = null;
            string dsMountPath = null;

            // check input datastore value
            if (ds == null) { return result; }
            if (ds.Summary != null) { if (ds.Summary.Url != null) { dsMountPath = ds.Summary.Url.Replace("ds://", "").TrimEnd('/'); } }
            if (dsMountPath == null)
            {
                Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. No summary data accessible.", ds.MoRef.ToString()));
                Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                return result;
            }

            // find out about mount point if not already done
            if (!_VIMountPointInfo.ContainsKey(dsMountPath))
            {
                string dsHostRef = null;
                string dsHostName = "";
                Common.VISoap.HostSystem dsHost = null;
                IPAddress dsHostAddr = null;
                List<string> dsOwners = new List<string> { };

                for (int i = 0; i < ds.Host.Count(); i++)
                {
                    Common.VISoap.HostSystem h = GetVIHostCached(ds.Host[i].Key);
                    if (h != null)
                    {
                        if (dsHost == null) { dsHost = h; dsHostName = h.Name; dsHostRef = ds.Host[i].Key.ToString(); }
                        dsOwners.Add(h.Name);
                    }
                    else
                    {
                        Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Cannot get info from host with moref: {1}", ds.Summary.Name, ds.Host[i].Key.ToString()));
                        Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                    }
                }
                if (dsHost == null) { return result; /* give up */ }

                string dsHostCluster = GetVICluster(dsHost.Parent.ToString());
                string dsHostDatacenter = GetVIDatacenter(dsHost.Parent.ToString());
                HostFileSystemMountInfo[] dsHostMountInfo = null;

                try
                {
                    HostNetworkSystem hostnetwork = GetVIHostNetworkCached(dsHost);
                    if (hostnetwork != null) { IPAddress.TryParse(hostnetwork.NetworkConfig.Vnic[0].Spec.Ip.IpAddress, out dsHostAddr); }
                    dsHostMountInfo = dsHost.Config.FileSystemVolume.MountInfo;
                }
                catch
                {
                    Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Cannot get info from host {1} ({2})", ds.Summary.Name, dsHostName, dsHostRef));
                    Log.Write("Warning: " + Queries[queryid].Warnings.Last());
                    return result; /* give up */
                }

                CSite dsHostSite = CSite.Resolve(dsHostAddr, _SiteInfo);

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
                                    CStorageConfig mountInfo = new CStorageConfig { FullPath = m.MountInfo.Path.ToString(), Site = dsHostSite, Cluster = dsHostCluster, Datacenter = dsHostDatacenter, Owner = dsOwners };
                                    mountInfo = GetViDatastoreMountDetails(queryid, ds, dsHost, mountInfo, m);

                                    if (mountInfo != null)
                                    {
                                        _VIMountPointInfo.Add(dsMountPath, mountInfo);
                                        i = dsHostMountInfo.Count(); //exit for
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // output mountpoint info
            if (_VIMountPointInfo.ContainsKey(dsMountPath))
            {
                result = _VIMountPointInfo[dsMountPath];
                string extents = String.Join(";", result.Children);
                Log.Write("  " + result.FullPath + "," + result.Owner[0] + ",local:" + result.Local.ToString().ToLower() + "," + result.Mode + "," + result.Type + "," + extents + "," + result.Model + "," + result.Vendor + "," + result.Details, Log.Verbosity.Debug);
            }

            return result;
        }

        private CStorageConfig GetViDatastoreMountDetails(int queryid, Datastore ds, Common.VISoap.HostSystem dsHost, CStorageConfig mountInfo, HostFileSystemMountInfo m)
        {
            CStorageConfig mi = mountInfo;
            string accessMode = m.MountInfo.AccessMode;

            if (m.Volume is HostNasVolume)
            {
                HostNasVolume vol = (HostNasVolume)m.Volume;
                mi.Local = false;
                mi.Mode = accessMode;
                mi.Type = vol.Type;
                mi.Details = vol.RemoteHost;
            }
            else if (m.Volume is HostVvolVolume)
            {
                HostVvolVolume vol = (HostVvolVolume)m.Volume;
                mi.Local = false;
                mi.Mode = accessMode;
                mi.Type = vol.Type;
            }
            else if (m.Volume is HostVfatVolume)
            {
                HostVfatVolume vol = (HostVfatVolume)m.Volume;
                mi.Local = true;
                mi.Mode = accessMode;
                mi.Type = "VFatVolume";
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
                foreach (string extent in extents) { mi.Children.Add(extent); }

                // adding mountpoint info
                mi.Local = volLocal;
                mi.Mode = accessMode;
                mi.Model = extentDiskModel;
                mi.Vendor = extentDiskVendor;
                mi.Details = extentDiskName;
                mi.Type = diskType;

            }
            else
            {
                mi = null;
                string mountVolume = "";
                if (m != null) { if (m.Volume != null) { mountVolume = m.Volume.GetType().ToString(); } }

                Queries[queryid].Warnings.Add(CFunctions.StringReplace("Cannot get datastore info from {0}. Unsupported datastore type: {1}", ds.Summary.Name, mountVolume));
                Log.Write("Warning: " + Queries[queryid].Warnings.Last());

            }
            return mi;
        }

        private Common.VISoap.HostSystem GetVIHostCached(ManagedObjectReference hostref)
        {
            Common.VISoap.HostSystem host = null;
            lock (_VIHostCacheLock)
            {
                if ((hostref != null) && !(_VIHosts.ContainsKey(hostref.ToString())))
                {
                    try
                    {
                        host = (Common.VISoap.HostSystem)VIClient.GetView(hostref, new string[] { "name", "parent", "vm", "datastore", "runtime", "configissue", "configstatus", "config.product", "configmanager.networksystem", "config.fileSystemVolume", "config.storageDevice", "hardware.cpuinfo", "hardware.memorysize", "hardware.systeminfo" });
                    }
                    catch (VimException ex)
                    {
                        host = null;
                        Log.Write("Cannot query host information. Error: " + ex.TargetSite + ex.Message);
                    }
                    _VIHosts.Add(hostref.ToString(), host); // add null hosts to prevent multiple queries for references that resolve to nothing
                }
                else
                {
                    host = _VIHosts[hostref.ToString()];
                }
            }
            return host;
        }

        internal List<CServiceConfig> GetVIVMs(int queryid)
        {
            List<CServiceConfig> VMsFound = new List<CServiceConfig> { };

            // dont continue if not logged in
            if (VISession == null) { return VMsFound; }

            // get vm info
            IList<EntityViewBase> vms = null;
            try { Log.Write("[ViSoap] Querying virtual machines associated with " + Server.Name.ToUpper()); vms = VIClient.FindEntityViews(typeof(VirtualMachine), null, null, new string[] { "parent", "configissue", "configstatus", "summary.storage", "summary.config", "config.name", "config.memoryallocation", "config.hardware", "config.version", "config.tools", "guest", "runtime", "layout.disk" }); }
            catch (Exception ex) { Log.Write("Cannot query virtual machine information. Error: " + ex.TargetSite + ex.Message); }
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

                        // storage usage, automatically exclude swap file size if powered on
                        double vswpusage = 0;
                        if (vm.Runtime.PowerState.ToString() == "poweredOn") { vswpusage = vm.Config.Hardware.MemoryMB - Convert.ToInt32(vm.Config.MemoryAllocation.Reservation); }

                        double storagealloc = (vm.Summary.Storage.Committed + vm.Summary.Storage.Uncommitted) / Math.Pow(1024, 2);
                        if ((storagealloc - vswpusage) > 0) { storagealloc -= vswpusage; }
                        double storageused = vm.Summary.Storage.Committed / Math.Pow(1024, 2);
                        if ((storageused - vswpusage) > 0) { storageused -= vswpusage; }
                        double storageunshared = vm.Summary.Storage.Unshared / Math.Pow(1024, 2);
                        if ((storageunshared - vswpusage) > 0) { storageunshared -= vswpusage; }

                        Int64[] diskusagereported = new Int64[] { (long)Math.Round(storagealloc, MidpointRounding.AwayFromZero), (long)Math.Round(storageused, MidpointRounding.AwayFromZero), (long)Math.Round(storageunshared, MidpointRounding.AwayFromZero) }; // need to expand depending on disk info
                        Int64[] diskusageactual = new Int64[] { 0, 0 };
                        //if (COptions.Preciseness == COptions.Precision.Medium)
                        //{
                        //   diskusageactual = diskusagereported;
                        //}
                        List<CStorageConfig> disks = GetVIVMDisks(queryid, vm);
                        string cluster = GetVICluster(vm.Runtime.Host.ToString());
                        string datacenter = GetVIDatacenter(vm.Runtime.Host.ToString());
                        string hostname = "";
                        Common.VISoap.HostSystem host = GetVIHostCached(vm.Runtime.Host);
                        if (host != null) { hostname = host.Name; }

                        CServiceConfig guestinfo = new CServiceConfig
                        {
                            Site = CSite.Resolve(ipaddr, _SiteInfo),
                            Name = vm.Config.Name.ToString(),
                            IP = ipaddr,
                            OS = vm.Summary.Config.GuestFullName,
                            CPUSockets = vm.Config.Hardware.NumCPU,
                            CPUCores = ((int)vm.Config.Hardware.NumCPU * vm.Config.Hardware.NumCoresPerSocket.GetValueOrDefault(1)),
                            RAM = vm.Config.Hardware.MemoryMB,
                            DiskUsageReported = diskusagereported,
                            DiskUsageActual = diskusageactual,
                            Disks = GetVIVMDisks(queryid, vm),
                            _HardwareVersion = vm.Config.Version,
                            _ToolsVersion = vm.Config.Tools.ToolsVersion.GetValueOrDefault(0).ToString(),
                            Cluster = cluster,
                            Datacenter = datacenter,
                            State = GetVIObjectState(vm),
                            Owner = new List<string> { hostname }
                        };

                        string logdata = "  ";
                        if (guestinfo.Site != null) { logdata = guestinfo.Site.Name + ","; }

                        logdata += guestinfo.Name.ToUpper() + "," + guestinfo.IP + "," + guestinfo.OS + "," + guestinfo.CPUSockets + " (" + guestinfo.CPUCores + " cores),memory:" + guestinfo.RAM + " (MB),allocated:" + guestinfo.DiskUsageReported[0] + " (MB),used:" + guestinfo.DiskUsageReported[1] + " (MB),unshared:" + guestinfo.DiskUsageReported[2] + " (MB),integration tools version: " + guestinfo._ToolsVersion;
                        Log.Write(logdata, Log.Verbosity.Debug);

                        VMsFound.Add(guestinfo);
                    }
                }

                VMsFound = VMsFound.OrderBy(o => o.Name).ToList(); // sort alphabetically

                // get additional details for thin vmdk files
                VMsFound = UpdateVIVMDiskDatastoreInfo(queryid, VMsFound);
            }

            return VMsFound;
        }

        private CDiscoveredState GetVIObjectState(object obj)
        {
            CDiscoveredState result = null;
            if (obj.GetType().ToString().Contains("VirtualMachine"))
            {
                VirtualMachine vm = (VirtualMachine)obj;
                string issues = "";
                foreach (Event e in vm.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result = new CDiscoveredState() { PowerState = vm.Runtime.PowerState.ToString(), ConfigState = vm.ConfigStatus.ToString(), ConfigIssues = issues, ConnectionState = vm.Runtime.ConnectionState.ToString() };
            }
            if (obj.GetType().ToString().Contains("HostSystem"))
            {
                Common.VISoap.HostSystem host = (Common.VISoap.HostSystem)obj;
                string issues = "";
                foreach (Event e in host.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result = new CDiscoveredState() { PowerState = host.Runtime.PowerState.ToString(), ConfigState = host.ConfigStatus.ToString(), ConfigIssues = issues, ConnectionState = host.Runtime.ConnectionState.ToString() };
            }
            if (obj.GetType().ToString().Contains("Datastore"))
            {
                Datastore ds = (Datastore)obj;
                string issues = "";
                foreach (Event e in ds.ConfigIssue) { issues += e.FullFormattedMessage + ";"; }
                result = new CDiscoveredState() { ConfigState = ds.ConfigStatus.ToString(), ConfigIssues = issues, };
            }
            return result;
        }

        private List<CStorageConfig> GetVIVMDisks(int queryid, VirtualMachine vm)
        {
            List<CStorageConfig> DisksFound = new List<CStorageConfig> { };

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

                        // set VM size info, and if not thin make these the same
                        long allocated = (Int64)Math.Round(disk.CapacityInKB / Math.Pow(1024, 1), MidpointRounding.AwayFromZero);
                        long used = 0;
                        if (!thin) { used = allocated; }

                        DisksFound.Add(new CStorageConfig() { Name = name, FullPath = path, _DSRef = dsref.ToString(), Thin = thin, Mode = mode.ToString(), Allocated = allocated, Used = used });
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
                        if (loc != -1) { DisksFound[loc].Children.Add(diskchild); }
                        else
                        {
                            /* no parent disk found -- add it as new parent */
                            string rootPath = diskchild.Split(']')[0].Replace("[", "").Trim();
                            string dsRef = DisksFound[0]._DSRef; // revert to default datastore if nothing is found (cheating -- I know, but remember we're searching a list of already known datastores and files so we should be safe)
                            string name = diskchild.Split(']')[1].Trim();
                            if (name.Contains('/')) { name = name.Substring(name.LastIndexOf('/') + 1); } // get filename by itself
                            for (int i = 0; i < DisksFound.Count; i++) // get datastore reference if we already have one
                            {
                                if (DisksFound[i].FullPath.Contains(rootPath)) { dsRef = DisksFound[i]._DSRef; i = DisksFound.Count; }
                            }
                            DisksFound.Add(new CStorageConfig() { Name = name, FullPath = diskchild, Allocated = 0, Thin = true, _DSRef = dsRef });
                            DisksFound[DisksFound.Count - 1].Children.Add(diskchild);
                        }
                    }
                }
            }

            return DisksFound;

        }

        private List<CServiceConfig> UpdateVIVMDiskDatastoreInfo(int queryid, List<CServiceConfig> vms) // issue with math here
        {
            HashSet<string> FilesToQuery = new HashSet<string> { };
            HashSet<string> QueryResults = new HashSet<string> { };

            if (COptions.Preciseness == COptions.Precision.High)
            {
                Log.Write("Getting details for thin provisioned VMs. This queries the datastore for information per folder for each VM in question.", Log.Verbosity.Verbose);

                // organize data for query
                for (int i = 0; i < vms.Count; i++)
                {
                    if ((vms[i].Disks) != null)
                    {
                        for (int j = 0; j < vms[i].Disks.Count; j++)
                        {
                            CStorageConfig disk = vms[i].Disks[j];
                            if (disk.Thin)
                            { // depends on compile-time constant
                              // need to update logic to detect if _DSRef refers to a VSAN datastore at which point it is better to use VI_Datastore_Search_Level = 1
                                if (COptions.VI_Datastore_Search_Level == 0) { string fq = disk._DSRef + "," + disk.FullPath.Split(']')[0] + "]"; if (!FilesToQuery.Contains(fq)) { FilesToQuery.Add(fq); } }
                                else if (COptions.VI_Datastore_Search_Level == 1) { string fq = disk._DSRef + "," + disk.FullPath; if (!FilesToQuery.Contains(fq)) { FilesToQuery.Add(fq); } }
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
                        for (int j = 0; j < vms[i].Disks.Count; j++)
                        {
                            if (vms[i].Disks[j].FullPath == dsfilepath)
                            {
                                vms[i].Disks[j].Used = 0; // found disk, clear incorrect "approximate data" from vSphere                        
                            }
                        }
                    }
                }

                QueryResults = QueryVIDatastores(queryid, FilesToQuery);

                // put data back into array
                foreach (string dsfile in QueryResults)
                {
                    string dsfilepath = dsfile.Split(',')[0];
                    string dsfilesize = dsfile.Split(',')[1];

                    for (int i = 0; i < vms.Count; i++)
                    {
                        for (int j = 0; j < vms[i].Disks.Count; j++)
                        {
                            for (int k = 0; k < vms[i].Disks[j].Children.Count(); k++)
                            {
                                if (vms[i].Disks[j].Children[k] == dsfilepath)
                                {
                                    vms[i].Disks[j].Used += (Int64)Math.Round(Double.Parse(dsfilesize), MidpointRounding.AwayFromZero);
                                    vms[i].Disks[j].Children[k] += "," + Double.Parse(dsfilesize); // append file size to child name
                                }
                            }
                        }
                    }
                }

                // update 'actual' datastore usage
                Int64[] diskusageactual = new Int64[] { 0, 0 };
                for (int i = 0; i < vms.Count; i++)
                {
                    for (int j = 0; j < vms[i].Disks.Count; j++)
                    {
                        vms[i].DiskUsageActual[0] += vms[i].Disks[j].Allocated;
                        vms[i].DiskUsageActual[1] += vms[i].Disks[j].Used;
                    }
                }
            }

            // output results
            if (COptions.Verbosity >= Log.Verbosity.Debug)
            {
                foreach (CServiceConfig vm in vms)
                {
                    Log.Write(CFunctions.StringReplace("Found disks ({0}) associated with {1}", vm.Disks.Count.ToString(), vm.Name.ToUpper()), Log.Verbosity.Debug);
                    foreach (CStorageConfig disk in vm.Disks)
                    {
                        // path, total, used, thick/thin
                        string output = CFunctions.StringReplace("  {0},allocated:{1} (MB),used:{2} (MB),thin:{3},(disk parts:", disk.FullPath, disk.Allocated.ToString(), disk.Used.ToString(), disk.Thin.ToString().ToLower());
                        output += String.Join(";", disk.Children);
                        Log.Write(output + ")", Log.Verbosity.Debug);
                    }
                }
            }

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
            if (_VIFilesFoundCache != null) { _VIFilesFoundCache.Clear(); _VIFilesFoundCache = null; }
            if (_VIMountPoints != null) { _VIMountPoints.Clear(); _VIMountPoints = null; }
            _VIMountPointInfo = null;
            if (_VIHosts != null) { _VIHosts.Clear(); _VIHosts = null; }
            if (_VIHostNetworkSystem != null) { _VIHostNetworkSystem.Clear(); _VIHostNetworkSystem = null; }
            _VIHostCacheLock = null;
            _VIHostNetworkSystemCacheLock = null;
        }
    }
}
