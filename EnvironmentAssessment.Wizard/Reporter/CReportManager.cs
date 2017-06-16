using System.Collections.Generic;

namespace EnvironmentAssessment.Reporter
{
    using Common.Inventory;
    using Common;
    using System;
    using Collector;

    class CReportManager
    {
        public bool Completed = false;
        public List<Common.CTaskInfo> SessionInfo = new List<Common.CTaskInfo> { };
        public CWriterManager WriterManager = new CWriterManager();

        public void RunReport(List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers)
        {
            string runtime = CFunctions.GetDateTime();
            string strJSONFile = Core.TempPath + "\\results-" + runtime + ".json";
            string strHTMLFile = Core.TempPath + "\\results-" + runtime + ".html";

            Core._ReportURI = @"http://127.0.0.1:8182/" + "results-" + runtime + ".html";

            string uid = CFunctions.GenerateUID();
            CWriter jsonWriter = new CWriter(new CWriter.Types(CWriter.Types.JSON), strJSONFile, DiscoveredSites, DiscoveredServers, uid);
            SessionInfo.Add(jsonWriter.Progress);
            WriterManager.Add(ref jsonWriter);
            CWriter htmlWriter = new CWriter(new CWriter.Types(CWriter.Types.HTML), strHTMLFile, DiscoveredSites, DiscoveredServers, uid);
            SessionInfo.Add(htmlWriter.Progress);
            WriterManager.Add(ref htmlWriter);
        }

        internal void Dispose()
        {
            WriterManager.Dispose();
            if (SessionInfo != null)
            {
                SessionInfo.Clear();
                SessionInfo = null;
            }
        }
        
        internal void Abort()
        {
            WriterManager.Abort();
        }
    }
}