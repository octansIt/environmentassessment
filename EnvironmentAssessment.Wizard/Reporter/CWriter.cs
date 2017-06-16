using System;
using EnvironmentAssessment.Common;
using System.Collections.Generic;
using System.Threading;
using EnvironmentAssessment.Common.Inventory;

namespace EnvironmentAssessment.Reporter
{
    public class CWriter
    {
        public class Types : IDisposable
        {
            private int _type;

            private static string[] WriterTypes = { "JSON", "CSV", "HTML", "PDF" };

            public const int JSON = 0;
            public const int CSV = 1;
            public const int HTML = 2;
            public const int PDF = 3;

            public Types(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                WriterTypes = null;
            }

            public override string ToString()
            {
                return WriterTypes[_type];
            }

            public static implicit operator int(Types x)
            {
                int i = x._type;
                return i;
            }
        }

        internal Types Type;
        internal string Outfile = "";
        internal bool Started = false;
        internal bool Completed = false;
        internal string ID;
        internal CTaskInfo Progress = null;
        internal string Error = "";
        internal List<string> Warnings = new List<string> { };

        public List<IDiscoveredObject> DiscoveredSites { get; set; }
        public List<IDiscoveredObject> DiscoveredServers { get; set; }

        public CWriter(Types type, string outfile, List<IDiscoveredObject> discoveredSites, List<IDiscoveredObject> discoveredServers, string uid)
        {
            this.DiscoveredSites = discoveredSites;
            this.DiscoveredServers = discoveredServers;
            Type = type;
            ID = uid;
            Outfile = outfile;
            Progress = new CTaskInfo() { Status = new CTaskInfo.State(CTaskInfo.State.Active), Details = "Generating " + Type.ToString() + " output to " + Outfile.ToLower(), UID = uid, StartTime = CFunctions.GetDateTime(0) };
            Log.Write(Progress.Details);
        }

        public void DoWork()
        {
            Completed = false;
            Started = true;
            string uid = CFunctions.GenerateUID();
            string starttime = CFunctions.GetDateTime(0);
            Log.Write("[Threading] Starting thread (" + uid + ") to generate " + Type.ToString() + " output to " + Outfile.ToLower(), Log.Verbosity.Everything);

            CThread.Types threadtype = new CThread.Types(CThread.Types.Unmanaged);

            if (this.Type == Types.JSON)
            {
                CJSONGenerator jw = new CJSONGenerator();
                CThread writer = new CThread() { Type = threadtype, Worker = new Thread(delegate () { jw.Write(this, Outfile, DiscoveredSites, DiscoveredServers); }), ID = uid };
                Core.ThreadManager.Add(writer);
            }
            else if(this.Type == Types.HTML)
            {
                CHTMLGenerator hw = new CHTMLGenerator();
                CThread writer = new CThread() { Type = threadtype, Worker = new Thread(delegate () { hw.Write(this, Outfile, DiscoveredSites, DiscoveredServers); }), ID = uid };
                Core.ThreadManager.Add(writer);
            }

        }

        public void Dispose()
        {
            ID = null;
        }
    }
}