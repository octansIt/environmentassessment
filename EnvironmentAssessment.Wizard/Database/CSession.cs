using System;
using EnvironmentAssessment.Common;
using System.Collections.Generic;
using System.Threading;
using EnvironmentAssessment.Common.Inventory;

namespace EnvironmentAssessment.Database
{
    public class CSession : IDisposable
    {
        CDatabaseConnection _DBConn;
        internal string Outfile = "";
        internal bool Started = false;
        internal bool Completed = false;
        internal string ID;
        internal CTaskInfo Progress = null;
        internal string Error = "";
        internal List<string> Warnings = new List<string> { };

        public List<IDiscoveredObject> DiscoveredSites { get; set; }
        public List<IDiscoveredObject> DiscoveredServers { get; set; }

        public CSession(ref CDatabaseConnection conn, List<IDiscoveredObject> discoveredSites, List<IDiscoveredObject> discoveredServers, string uid)
        {
            _DBConn = conn;
            this.DiscoveredSites = discoveredSites;
            this.DiscoveredServers = discoveredServers;
            ID = uid;
            Outfile = conn.FileName;
            Progress = new CTaskInfo() { Status = new CTaskInfo.State(CTaskInfo.State.Active), Details = "Generating database output to " + Outfile.ToLower(), UID = uid, StartTime = CFunctions.GetDateTime(0) };
            Log.Write(Progress.Details);
        }

        public void DoWork()
        {
            Completed = false;
            Started = true;
            string uid = CFunctions.GenerateUID();
            string starttime = CFunctions.GetDateTime(0);
            Log.Write("[Threading] Starting thread (" + uid + ") to generate database output to " + Outfile.ToLower(), Log.Verbosity.Everything);

            CThread.Types threadtype = new CThread.Types(CThread.Types.Unmanaged);

            CDatabaseExporter de = new CDatabaseExporter();
            CThread exporter = new CThread() { Type = threadtype, Worker = new Thread(delegate () { de.Export(this, ref _DBConn, DiscoveredSites, DiscoveredServers); }), Id = uid };
            Core.ThreadManager.Add(exporter);
        }

        public void Dispose()
        {
            ID = null;
        }
    }
}