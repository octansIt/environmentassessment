using System;
using System.Collections.Generic;
using System.Threading;

namespace EnvironmentAssessment.Common
{
    class CThreadManager : IDisposable
    {
        internal int CompletionCount = 0;
        internal int QueuedCount = -1;

        private CThread ThreadManager;
        private bool Terminated = false;

        private List<CThread> QueuedThreads = new List<CThread> { };
        private List<CThread> ActiveThreads = new List<CThread> { };

        // zzz - need to improve http://stackoverflow.com/questions/8028483/managing-threads-using-listthread

        public CThreadManager()
        {
            // start session manager thread
            Thread.CurrentThread.Name = CFunctions.GenerateUID();
            ThreadManager = new CThread() { Worker = new Thread(new ThreadStart(ManageThreads)) };
            Log.Write("[Threading] Primary thread (" + Thread.CurrentThread.Name + ") of type: '" + ThreadManager.Type + "' with scheduler id: " + Thread.CurrentThread.ManagedThreadId + " started at: " + Core._StartTime, 7);
            ThreadManager.Start();
            Log.Write("[Threading] Starting new thread (" + ThreadManager.Id + ") of type: '" + ThreadManager.Type + "' with scheduler id: " + ThreadManager.Worker.ManagedThreadId, 7);
        }

        public void ManageThreads()
        {
            do
            {
                int tc = 0;

                for (int i = 0; i < ActiveThreads.Count; i++)
                {
                    CThread thread = ActiveThreads[i];
                    if (thread.Type != CThread.Types.Unmanaged) tc++;
                    if (thread.Completed)
                    {
                        CompletionCount++;
                        Log.Write("[Threading] Thread id: " + thread.Worker.ManagedThreadId + " (" + thread.Id + ") has completed.", 7);
                        ActiveThreads.Remove(thread);
                    }
                }
                for (int i = 0; i < QueuedThreads.Count; i++)
                {
                    if (tc < COptions.Thread_Max_Total)
                    {
                        bool start = false;
                        CThread thread = QueuedThreads[i];
                        if ((thread.Type == CThread.Types.VMware) && (thread.Session.ThreadCount < COptions.Thread_Max_VI_Per_Instance)) { start = true; thread.Session.ThreadCount++; }
                        else if ((thread.Type == CThread.Types.HyperV) && (thread.Session.ThreadCount < COptions.Thread_Max_HV_Per_Instance)) { start = true; thread.Session.ThreadCount++; }
                        else if ((thread.Type == CThread.Types.Unmanaged)) { start = true; }

                        if (start)
                        {
                            Log.Write("[Threading] Starting new thread (" + thread.Id + ") of type: '" + thread.Type + "' with scheduler id: " + thread.Worker.ManagedThreadId, 7);
                            thread.Start();
                            ActiveThreads.Add(thread);
                            QueuedThreads.Remove(thread);
                        }
                    }
                }
                Thread.Sleep(COptions.Thread_Wait);
            } while (!Terminated);
            Log.Write("[Threading] Thread id: " + Thread.CurrentThread.ManagedThreadId + " (" + ThreadManager.Id + ") has completed.", 7);
        }

        public void Add(CThread thread)
        {
            thread.Worker.Name = thread.Id;
            QueuedThreads.Add(thread);
            if (QueuedCount == -1) { QueuedCount = 1; }
            else { QueuedCount++; }
        }

        public void Abort()
        {
            Terminated = true;
            if (ActiveThreads != null) { for(int i = 0; i < ActiveThreads.Count; i++) { ActiveThreads[i].Abort(); } }
        }

        public void Quit()
        {
            Abort();
            Log.Write("[Threading] Thread id: " + Thread.CurrentThread.ManagedThreadId + " (" + Thread.CurrentThread.Name + ") has completed.", 7);
        }
        public void Dispose()
        {
            this.Abort();
            if (QueuedThreads != null)
            {
                QueuedThreads.Clear();
                QueuedThreads = null;
            }
            if (ActiveThreads != null)
            {
                ActiveThreads.Clear();
                ActiveThreads = null;
            }
        }
    }
}
