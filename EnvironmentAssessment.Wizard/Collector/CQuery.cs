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

            private static string[] QueryTypes = { "Host", "Datastore", "Guest" };

            public const int Hosts = 0;
            public const int Datastores = 1;
            public const int VMs = 2;

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
        internal Types Type;
        internal bool Started = false;
        internal bool Completed = false;
        internal string ID;
        internal List<CSite> Sites = new List<CSite> { };
        internal List<CServiceConfig> Result = new List<CServiceConfig> { };
        internal CTaskInfo Progress = null;
        internal string Error = "";
        internal List<string> Warnings = new List<string> { };

        public CQuery(ref CSession parent, Types type, List<CSite> sites, string uid)
        {
            Session = parent;
            Type = type;
            Sites = sites;
            ID = uid;
            Progress = new CTaskInfo { Status = new CTaskInfo.State(CTaskInfo.State.Active), Service = Session.Server.Name, StartTime = CFunctions.GetDateTime(0), UID = uid, Details = "Collecting " + Type.ToString().ToLower() + " info from " + Session.Server.Type.ToString() + " " + Session.Server.Name.ToUpper() + " (" + Session.Server.IP.ToString() + ")" };
            Log.Write(Progress.Details);
        }

        public void Dispose()
        {
            ID = null;
            Sites = null;
            Result = null;
        }

    }
}
