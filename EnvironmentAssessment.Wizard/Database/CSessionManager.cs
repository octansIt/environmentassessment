using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EnvironmentAssessment.Database
{
    class CSessionManager : IDisposable
        {
            private List<CSession> ActiveSessions;
            private List<CSession> QueuedSessions;

            internal int CompletionCount = 0;
            internal int QueuedCount = -1;

            private CThread WriterManager;
            private bool Terminated = false;
            public bool Completed = false;

            public int ErrorCount = 0;

            public CSessionManager()
            {
                // start session manager thread
                ActiveSessions = new List<CSession> { };
                QueuedSessions = new List<CSession> { };
                WriterManager = new CThread() { Worker = new Thread(new ThreadStart(ManageSessions)) };
                Core.ThreadManager.Add(WriterManager);
            }

            private void ManageSessions()
            {
                do
                {
                    for (int i = 0; i < ActiveSessions.Count; i++)
                    {
                        if (ActiveSessions[i].Completed)
                        {
                            if (ActiveSessions[i].Error.Length > 0) { ErrorCount += 1; }
                            CompletionCount++;
                            ActiveSessions.RemoveAt(i);
                        }
                    }

                    for (int i = 0; i < QueuedSessions.Count; i++)
                    {

                        if (ActiveSessions.Count < COptions.Session_Thread_Max) // mark session as active
                        {
                            ActiveSessions.Add(QueuedSessions[i]);
                            QueuedSessions.RemoveAt(i);
                        }
                    }

                    for (int i = 0; i < ActiveSessions.Count; i++) // run active sessions
                    {
                        if (!ActiveSessions[i].Started) { ActiveSessions[i].DoWork(); }
                    }

                    if (ActiveSessions.Count == 0 && QueuedSessions.Count == 0 && QueuedCount == CompletionCount) { Completed = true; Terminated = true; }
                    else { Completed = false; }
                    Thread.Sleep(COptions.Session_Thread_Wait);
                } while (!Terminated);
            }

            public void Add(ref CSession writer)
            {
                Completed = false;
                QueuedSessions.Add(writer);
                if (QueuedCount == -1) { QueuedCount = 1; }
                else { QueuedCount++; }
            }

            public int Active() { return ActiveSessions.Count(); }

            public int Queued() { return QueuedSessions.Count(); }

            public void Abort()
            {
                WriterManager.Abort();
            }

            public void Dispose()
            {
                // update to cleanup session
                this.Abort();
                ActiveSessions = null;
                QueuedSessions = null;
                WriterManager = null;
            }

        }
}
