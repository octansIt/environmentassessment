using System;
using System.Collections.Generic;
using System.Linq;

namespace EnvironmentAssessment.Collector
{
    using Common.VimApi;
    using Common.HvApi;
    using Common.VbrApi;
    using Collector;
    using System.Net;
    using System.Threading;
    using System.Net.Sockets;
    using System.Windows;
    using System.Management;
    using Common;
    using Common.Inventory;

    public class CSession : IDisposable
    {
        ISession Session = null;        
        //internal string SessionID;

        public int ThreadCount;

        internal CService Server
        {
            get
            {
                try { return Session.Server; }
                catch { return null; }
            }
        }

        internal bool Started { get
            {
                try { return Session.Started; }
                catch { return false; }
            }
            set
            {
                Session.Started = value;
            }
        }

        internal string Error { get
            {
                try { return Session.Error; }
                catch { return null; }
            }
        }

        internal List<CQuery> Queries
        {
            get
            {
                try { return Session.Queries; }
                catch { return null; }
            }
        }

        internal bool Completed
        {
            get
            {
                try { return Session.Completed; }
                catch { return false; }
            }
        }

        internal CSession(CService server)
        {
            // initialize server session object
            if ((server.Type == CServiceType.ESXServer) || (server.Type == CServiceType.VCenterServer))
            {
                Session = new VimSession(ref server);
            }
            else if ((server.Type == CServiceType.SCVMMServer) || (server.Type == CServiceType.HYVServer))
            {
                Session = new HviSession(ref server);
            }
            else if (server.Type == CServiceType.VBRServer)
            {
                Session = new VbrSession(ref server);
            }
        }

        public void Connect()
        {
            if ((Session.Server.Type == CServiceType.ESXServer) || (Session.Server.Type == CServiceType.VCenterServer))
            {
                ((VimSession)Session).Connect();
            }
            else if ((Session.Server.Type == CServiceType.SCVMMServer) || (Session.Server.Type == CServiceType.HYVServer))
            {
                ((HviSession)Session).Connect();
            }
            else if (Session.Server.Type == CServiceType.VBRServer)
            {
                ((VbrSession)Session).Connect();
            }
        }

        public void Disconnect()
        {
            if (Session.Connected == true)
            {
                if ((Server.Type == CServiceType.ESXServer) || (Server.Type == CServiceType.VCenterServer))
                {

                    try { ((VimSession)Session).Disconnect(); }
                    catch { } // do nothing right now if this fails

                }
                else if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer))
                {
                    try { ((HviSession)Session).Disconnect(); }
                    catch { } // do nothing right now if this fails
                }
                else if (Server.Type == CServiceType.VBRServer)
                {
                    try { ((VbrSession)Session).Disconnect(); }
                    catch { } // do nothing right now if this fails
                }
                Session = null;
            }
        }
        
        public void DoWork()
        {
            Session.Completed = false;
            QueryManager(); // run queries
        }

        private void QueryManager()
        {
            for (int i = 0; i < Session.Queries.Count; i++)
            {
                if (!Session.Queries[i].Started)
                {
                    string tid = CFunctions.GenerateUID();
                    int id = i; // using local context variable to allow delegation
                    Log.Write("[Threading] Starting thread (" + tid + ") to run session query " + (i + 1) + "/" + Session.Queries.Count + " (" + Session.Queries[i].Id + ").", Log.Verbosity.Everything);
                    
                    CThread.Types threadtype = new CThread.Types(CThread.Types.Unmanaged);
                    if ((Server.Type == CServiceType.ESXServer) || (Server.Type == CServiceType.VCenterServer)) { threadtype = new CThread.Types(CThread.Types.VMware); }
                    if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer)) { threadtype = new CThread.Types(CThread.Types.HyperV); }
                    
                    Core.ThreadManager.Add(new CThread() { Type = threadtype, Worker = new Thread(delegate() { DoQuery(id); }), Session = this, Id = tid });
                }
            }
            do {
                bool status = true;
                for (int i = 0; i < Session.Queries.Count; i++) { if (!Session.Queries[i].Completed) { status = false; } }
                Session.Completed = status;
                Thread.Sleep(COptions.Session_Thread_Wait); 
            } while (!Session.Completed);
        }

        internal void AddQuery(CQuery query)
        {
            Session.Queries.Add(query);
            if (Session.Completed) { Session.Completed = false; } // mark session as incomplete as new query is added to the stack
        }

        private void DoQuery(int id)
        {
            //int id = Int16.Parse(o.ToString());
            Log.Write("[Threading] Thread started for query " + (id+1) + "/" + Session.Queries.Count, Log.Verbosity.Everything);
            //Log.Write(" : DoQuery (id: " + _Queries[id].Type + ", [server: " + Server.Name + "])", Log.Verbosity.Everything);

            if (!Session.Queries[id].Completed && !Session.Queries[id].Started)
            {
                Session.Queries[id].Started = true;
                Session.SiteInfo = Session.Queries[id].Sites; // import site data for resolution

                if (Session.Queries[id].Type == CQuery.Types.Hosts) { QueryHosts(id); }
                if (Session.Queries[id].Type == CQuery.Types.Datastores) { QueryDatastores(id); }
                if (Session.Queries[id].Type == CQuery.Types.VMs) { QueryVMs(id); }
                if (Session.Queries[id].Type == CQuery.Types.Components) { QueryComponents(id); }
                if (Session.Queries[id].Type == CQuery.Types.Events) { QueryEvents(id); }

                // rollup results
                if (Session.Error.Length > 0)
                {
                    Session.Queries[id].Progress.Status = new CTaskInfo.State(CTaskInfo.State.Error);
                    Session.Queries[id].Progress.Details = this.Server.Name.ToUpper() + ": " + Session.Error;
                }
                else if (Session.Queries[id].Warnings.Count > 0)
                {
                    Session.Queries[id].Progress.Status = new CTaskInfo.State(CTaskInfo.State.Warning);
                    Session.Queries[id].Progress.Details = this.Server.Name.ToUpper() + ": " + Session.Queries[id].Warnings[0] + " (+" + Session.Queries[id].Warnings.Count() + " more)";
                }
                else { Session.Queries[id].Progress.Status = new CTaskInfo.State(CTaskInfo.State.Success); }

                //Log.Write(" : DoQuery (completed)");
                Session.Queries[id].Completed = true;
            }
        }

        private void QueryVMs(int queryid)
        {
            List<CDiscoveredConfig> result = new List<CDiscoveredConfig> { };

            if ((Server.Type == CServiceType.VCenterServer) || (Server.Type == CServiceType.ESXServer)) { result = ((VimSession)Session).GetVms(queryid); }
            if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer)) { result = ((HviSession)Session).GetVms(queryid); }
            
            Session.Queries[queryid].Result = result;
        }

        private void QueryHosts(int queryid)
        {
            List<CDiscoveredConfig> result = new List<CDiscoveredConfig> { };

            if ((Server.Type == CServiceType.VCenterServer) || (Server.Type == CServiceType.ESXServer)) { result = ((VimSession)Session).GetHosts(queryid); }
            if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer)) { result = ((HviSession)Session).GetHosts(queryid); }
            
            Session.Queries[queryid].Result = result;
        }

        private void QueryComponents(int queryid)
        {
            List<CDiscoveredConfig> result = new List<CDiscoveredConfig> { };

            if ((Server.Type == CServiceType.VBRServer)) { result = ((VbrSession)Session).GetComponents(queryid); }

            Session.Queries[queryid].Result = result;
        }

        private void QueryEvents(int queryid)
        {
            List<CDiscoveredConfig> result = new List<CDiscoveredConfig> { };

            if ((Server.Type == CServiceType.VBRServer)) { result = ((VbrSession)Session).GetEvents(queryid); }

            Session.Queries[queryid].Result = result;
        }

        private void QueryDatastores(int queryid)
        {
            List<CDiscoveredConfig> result = new List<CDiscoveredConfig> { };
            List<CDiscoveredConfig> datastores = new List<CDiscoveredConfig> { };

            if ((Server.Type == CServiceType.VCenterServer) || (Server.Type == CServiceType.ESXServer)) { datastores = ((VimSession)Session).GetDatastores(queryid); }
            if ((Server.Type == CServiceType.SCVMMServer) || (Server.Type == CServiceType.HYVServer)) { datastores = ((HviSession)Session).GetDatastores(queryid); }

            if (datastores != null)
            {
                result.Add(new CDiscoveredConfig() { ChildObjects = datastores });
            }

            Session.Queries[queryid].Result = result;
        }


        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                Session.Dispose();
                //Server.Dispose(); // not sure if this would break object references at this point
            }
            // free native resources if there are any
            //Session.Error = null;
            //if (Session.Queries != null) { Session.Queries.Clear(); Session.Queries = null; }
            //if (_SiteInfo != null) { _SiteInfo.Clear(); _SiteInfo = null; }

        }        
    }

}
