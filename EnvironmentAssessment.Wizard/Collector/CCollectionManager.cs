using System;
using System.Collections.Generic;
using System.Linq;

namespace EnvironmentAssessment.Collector
{
    // associate each metric with a collection frequency
    // when doing this need to make sure that sessions time out after a certain time
    using Common;
    using Common.Inventory;

    public class CCollectionSchedule : IDisposable
    {
        private int _type;
        private static string[] CollectionSchedules = { "Run Once" };
        public const int RunOnce = 0;

        public CCollectionSchedule(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            CollectionSchedules = null;
        }

        public override string ToString()
        {
            return CollectionSchedules[_type];
        }

        public static implicit operator int(CCollectionSchedule x)
        {
            int i = x._type;
            return i;
        }
    }

    public class CCollectionManager : IDisposable
    {
        public CSessionManager SessionManager = new CSessionManager();
        public List<CTaskInfo> SessionInfo = new List<CTaskInfo> { };
        private bool Started = false;

        internal void RunStatisticsCollector(List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers, List<CQuery.Types> queries, CCollectionSchedule schedule)
        {

            string uid;

            //Log.Write(" : RunStatisticsCollector (discoveredsites: " + DiscoveredSites.Count + ", discoveredservers: " + DiscoveredServers.Count + ", queries: " + queries.Count + ", schedule: " + schedule + ")", Log.Verbosity.Everything);

            IEnumerable<CSite> sites = DiscoveredSites.OfType<CSite>();
            List<CSite> SiteList = new List<CSite> { };
            SiteList.AddRange(sites);

            IEnumerable<CService> servers = DiscoveredServers.OfType<CService>();
            List<CService> ServerList = new List<CService> { };
            ServerList.AddRange(servers);

            /* string output = " : RunStatisticsCollector(registering sessions for: ";
            foreach (CService s in ServerList)
            {
                output += s.Name + ", ";
            }
            Log.Write(output + ")", Log.Verbosity.Everything); */

            if (schedule == CCollectionSchedule.RunOnce)
            {
                // get information
                for (int i = 0; i < ServerList.Count(); i++ )
                {
                    //Log.Write(" : RunStatisticsCollector (looping through servers " + ServerList[i].Name + ")", Log.Verbosity.Everything);
                    uid = CFunctions.GenerateUID();

                    if (!Started) { ServerList[i].Initialize(); }

                    foreach (CQuery.Types type in queries)
                    {
                        CQuery query = new CQuery(ref ServerList[i].Session, type, SiteList, uid);
                        SessionInfo.Add(query.Progress);
                        ServerList[i].Session.AddQuery(query);
                    }

                    // Log.Write(" : RunStatisticsCollector (registering session " + ServerList[i].Session.Server.Name + ")", Log.Verbosity.Everything);
                    SessionManager.Add(ref ServerList[i].Session);
                }

                Started = true;
                // Log.Write(" : RunStatisticsCollector (completed)", Log.Verbosity.Everything);

                // later
                // get vbr job information
                // get vbr configuration, later get host configuration etc...
                // get physical server and client configuration (discovery by wildcard name, using AD)
                // make get host, datastore and guest work for KVM and then Azure, AWS, GCE
                // ...
                // get information by using network scanning (discovery by ip address, using port scanning)
                // get information from storage systems
            }
        }

        internal void Abort()
        {
            SessionManager.Abort();
        }

        public void Dispose()
        {
            if (SessionManager != null) { SessionManager.Dispose(); }
        }
    }
}
