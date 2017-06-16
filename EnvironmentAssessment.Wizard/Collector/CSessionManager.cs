using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EnvironmentAssessment.Collector
{
    public class CSessionManager : IDisposable
    {
        private List<CSession> ActiveSessions;
        private List<CSession> CompletedSessions;
        private List<CSession> QueuedSessions;

        internal int CompletionCount = 0;
        internal int QueuedCount = -1;

        private CThread SessionManager;
        private bool _Terminated = false;
        private bool Terminated {
            get { lock (_TerminationLock) { return _Terminated; } }
            set { lock (_TerminationLock) { _Terminated = Terminated; } }
        }

        private object _TerminationLock = new Object();
        public bool Completed = false;

        public int ErrorCount = 0;

        public CSessionManager()
        {
            // Log.Write(" : CSessionManager (initialized)", Log.Verbosity.Everything);

            // start session manager thread
            CompletedSessions = new List<CSession> { };
            ActiveSessions = new List<CSession> { };
            QueuedSessions = new List<CSession> { };
            SessionManager = new CThread() { Worker = new Thread(new ThreadStart(ManageSessions)) };
            Core.ThreadManager.Add(SessionManager);
        }

        private void ManageSessions()
        {
            do
            {
                for (int i = 0; i < ActiveSessions.Count; i++)
                {
                    if (ActiveSessions[i].Completed)
                    {
                        // Log.Write(" : CSessionManager (completed session " + ActiveSessions[i].Server.Name + ")", Log.Verbosity.Everything);
                        if (ActiveSessions[i].Server.Session.Error.Length > 0) { ErrorCount += 1; }
                        CompletionCount++;
                        if (!CompletedSessions.Contains(ActiveSessions[i])) { CompletedSessions.Add(ActiveSessions[i]); }
                        ActiveSessions.RemoveAt(i);
                    }
                }

                for (int i = 0; i < QueuedSessions.Count; i++)
                {

                    if (ActiveSessions.Count < COptions.Session_Thread_Max) // mark session as active
                    {
                        // Log.Write(" : CSessionManager (starting session " + QueuedSessions[i].Server.Name + ")", Log.Verbosity.Everything);
                        QueuedSessions[i].Connect(); // only connect if not already connected
                        ActiveSessions.Add(QueuedSessions[i]);
                        QueuedSessions.RemoveAt(i);
                    }
                }

                for (int i = 0; i < ActiveSessions.Count; i++) // run active sessions
                {
                    if (!ActiveSessions[i].Started) { ActiveSessions[i].DoWork(); }
                }

                if (ActiveSessions.Count == 0 && QueuedSessions.Count == 0 && QueuedCount == CompletionCount) { Completed = true; }
                else { Completed = false; }
                Thread.Sleep(COptions.Session_Thread_Wait);
            } while (!Terminated);
        }

        public void Add(ref CSession session)
        {
            Completed = false;
            if (session.Started) { session.Started = false; } // even if the session has been started before, we need to resume it 
            // Log.Write(" : CSessionManager (queueing session " + session.SessionID + ")", Log.Verbosity.Everything);
            QueuedSessions.Add(session);
            if (QueuedCount == -1) { QueuedCount = 1; }
            else { QueuedCount++; }
        }

        public int Active() { return ActiveSessions.Count(); }

        public int Queued() { return QueuedSessions.Count(); }

        public void Abort()
        {
            SessionManager.Abort();
        }

        public void Dispose()
        {
            // update to cleanup session
            // Log.Write(" : CSessionManager (disposed)", Log.Verbosity.Everything);
            Terminated = true;
            foreach (CSession session in CompletedSessions) { session.Disconnect(); }
            this.Abort();
            ActiveSessions = null;
            QueuedSessions = null;
            SessionManager = null;
        }

    }
}
