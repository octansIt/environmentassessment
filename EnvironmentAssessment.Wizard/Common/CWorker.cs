using System.ComponentModel;
using System.Threading;

namespace EnvironmentAssessment.Common
{
    public class CWorker : BackgroundWorker
    {
        CThread workerThread;
        bool Started = false;

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            if (!Started)
            {
                Started = true;
                workerThread = new CThread() { Worker = Thread.CurrentThread };
                Log.Write("[Threading] Starting new thread (" + workerThread.ID + ") of type: '" + workerThread.Type + "' with scheduler id: " + workerThread.Worker.ManagedThreadId, 7);
                try
                {
                    base.OnDoWork(e);
                }
                catch (ThreadAbortException)
                {
                    e.Cancel = true;
                    Thread.ResetAbort();
                }
                if (workerThread != null) { Log.Write("[Threading] Thread id: " + workerThread.Worker.ManagedThreadId + " (" + workerThread.ID + ") has completed.", 7); }
            }
        }

        public void Reset()
        {
            Started = false;
        }

        public void Abort()
        {
            if (workerThread != null)
            {
                workerThread.Abort();
                workerThread = null;
            }
        }

    }
}
