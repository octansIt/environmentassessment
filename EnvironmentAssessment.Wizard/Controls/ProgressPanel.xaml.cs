using System.Windows.Controls;

namespace EnvironmentAssessment.Controls
{
    /// <summary>
    /// Interaction logic for ProgressPanel.xaml
    /// </summary>
    /// 
    using Common;
    using System.Threading;

    public partial class ProgressPanel : UserControl
    {
        public GridView lgvProgress = new GridView() { AllowsColumnReorder = false };
        public CWorker UpdateTimer = new CWorker() { };
            
        public bool Running = false;
        public bool Complete = false;

        public ProgressPanel()
        {
            InitializeComponent();

            lvProgress.View = lgvProgress;

            UpdateTimer.WorkerReportsProgress = true;
            UpdateTimer.ProgressChanged += UpdateTimer_ProgressChanged;
            UpdateTimer.DoWork += UpdateTimer_DoWork;
        }

        public void Activate()
        {
            Running = true;
            UpdateTimer.Reset();
            UpdateTimer.RunWorkerAsync();
        }

        void UpdateTimer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {
                Thread.Sleep(COptions.Display_Thread_Wait);
                UpdateTimer.ReportProgress(0, null);
            } while (Running);
        }

        void UpdateTimer_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (lvProgress.Items != null) { lvProgress.Items.Refresh(); }
        }


        internal void SetProgress(int p)
        {
            if (p == 100)
            {
                Complete = true;
                Running = false;
            }
            pbProgress.Value = p;
        }
    }

   
}
