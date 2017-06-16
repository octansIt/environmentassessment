using EnvironmentAssessment.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EnvironmentAssessment.Reporter
{
    class CWriterManager : IDisposable
        {
            private List<CWriter> ActiveWriters;
            private List<CWriter> QueuedWriters;

            internal int CompletionCount = 0;
            internal int QueuedCount = -1;

            private CThread WriterManager;
            private bool Terminated = false;
            public bool Completed = false;

            public int ErrorCount = 0;

            public CWriterManager()
            {
                // start session manager thread
                ActiveWriters = new List<CWriter> { };
                QueuedWriters = new List<CWriter> { };
                WriterManager = new CThread() { Worker = new Thread(new ThreadStart(ManageSessions)) };
                Core.ThreadManager.Add(WriterManager);
            }

            private void ManageSessions()
            {
                do
                {
                    for (int i = 0; i < ActiveWriters.Count; i++)
                    {
                        if (ActiveWriters[i].Completed)
                        {
                            if (ActiveWriters[i].Error.Length > 0) { ErrorCount += 1; }
                            CompletionCount++;
                            ActiveWriters.RemoveAt(i);
                        }
                    }

                    for (int i = 0; i < QueuedWriters.Count; i++)
                    {

                        if (ActiveWriters.Count < COptions.Session_Thread_Max) // mark session as active
                        {
                            ActiveWriters.Add(QueuedWriters[i]);
                            QueuedWriters.RemoveAt(i);
                        }
                    }

                    for (int i = 0; i < ActiveWriters.Count; i++) // run active sessions
                    {
                        if (!ActiveWriters[i].Started) { ActiveWriters[i].DoWork(); }
                    }

                    if (ActiveWriters.Count == 0 && QueuedWriters.Count == 0 && QueuedCount == CompletionCount) { Completed = true; Terminated = true; }
                    else { Completed = false; }
                    Thread.Sleep(COptions.Session_Thread_Wait);
                } while (!Terminated);
            }

            public void Add(ref CWriter writer)
            {
                Completed = false;
                QueuedWriters.Add(writer);
                if (QueuedCount == -1) { QueuedCount = 1; }
                else { QueuedCount++; }
            }

            public int Active() { return ActiveWriters.Count(); }

            public int Queued() { return QueuedWriters.Count(); }

            public void Abort()
            {
                WriterManager.Abort();
            }

            public void Dispose()
            {
                // update to cleanup session
                this.Abort();
                ActiveWriters = null;
                QueuedWriters = null;
                WriterManager = null;
            }

        }
}
