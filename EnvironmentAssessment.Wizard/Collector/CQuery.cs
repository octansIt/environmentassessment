using System;
using System.Collections.Generic;

namespace EnvironmentAssessment.Collector
{
    using Common.Inventory;
    using Common;

    internal class CQuery : IDisposable
    {
        internal class Types : IDisposable
        {
            private int _type;

            internal static string[] QueryTypes = { "Host", "Datastore", "Guest", "Component", "Event", "Log"  };

            public const int Hosts = 0;
            public const int Datastores = 1;
            public const int VMs = 2;
            public const int Components = 3;
            public const int Events = 4;
            public const int Logs = 5;

            public Types(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                QueryTypes = null;
            }

            public override string ToString()
            {
                return QueryTypes[_type];
            }

            public static implicit operator int(Types x)
            {
                int i = x._type;
                return i;
            }
        }
        internal CSession Session = null;
        internal int Type;
        internal bool Started = false;
        internal bool Completed = false;
        internal string Id;
        internal List<CSite> Sites = new List<CSite> { };
        internal List<CDiscoveredConfig> Result = new List<CDiscoveredConfig> { };
        internal CTaskInfo Progress = null;
        internal string Error = "";
        internal List<string> Warnings = new List<string> { };

        public CQuery(ref CSession parent, int type, List<CSite> sites, string uid)
        {
            Session = parent;
            Type = type;
            Sites = sites;
            Id = uid;
            Progress = new CTaskInfo { Status = new CTaskInfo.State(CTaskInfo.State.Active), Service = Session.Server.Name, StartTime = CFunctions.GetDateTime(0), UID = uid, Details = "Collecting " + CQuery.Types.QueryTypes[Type].ToString().ToLower() + " info from " + Session.Server.Type.ToString() + " " + Session.Server.Name.ToUpper() + " (" + Session.Server.IP.ToString() + ")" };
            Log.Write(Progress.Details);
        }

        public void Dispose()
        {
            Id = null;
            Sites = null;
            Result = null;
        }

    }
}
