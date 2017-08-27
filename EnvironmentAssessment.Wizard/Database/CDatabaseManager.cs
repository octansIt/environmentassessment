using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;

namespace EnvironmentAssessment.Database
{
    class CDatabaseManager
    {
        CDatabaseConnection _DBConn;

        public List<Common.CTaskInfo> SessionInfo = new List<Common.CTaskInfo> { };
        public CSessionManager SessionManager = new CSessionManager();

        internal CDatabaseConnection InitializeDB()
        {
            CDatabaseConnection conn = null;
            CFunctions.CreateFolderIfNotExist(Core.DatabasePath);
            conn = new CDatabaseConnection(Core.DatabasePath + "\\" + Core._StartTime + ".db");
            if (conn._DBTryInitialize())
            {
                return conn;
            }
            else { return null;  }
        }

        public void Export(List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers)
        {
            Core._ReportURI = @"http://127.0.0.1:8182/";

            if (_DBConn == null) { _DBConn = InitializeDB(); }

            string uid = CFunctions.GenerateUID();

            CSession exporter = new CSession(ref _DBConn, DiscoveredSites, DiscoveredServers, uid);
            SessionInfo.Add(exporter.Progress);
            SessionManager.Add(ref exporter);
        }

        internal void Dispose()
        {
            if (_DBConn != null)
            {
                _DBConn.Dispose();
            }
            SessionManager.Dispose();
            if (SessionInfo != null)
            {
                SessionInfo.Clear();
                SessionInfo = null;
            }
        }

        internal void Abort()
        {
            SessionManager.Abort();
        }
    }
}