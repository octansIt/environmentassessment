using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows.Interop;

namespace EnvironmentAssessment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    using System.Threading;
    using Common.Inventory;
    using Common;
    using Collector;
    using Database;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Windows.Shell;

    public partial class AppWizard : Controls.Wizard
    {
        
        internal Border cntTop, cntNav, cntMain, cntBottom;
        internal Label lblTitle;
        internal TextBlock tbkSubTitle;
        internal Button btnPrevious, btnNext, btnCancelFinish;

        List<IDiscoveredObject> DiscoveredServers = new List<IDiscoveredObject> { };
        List<IDiscoveredObject> DiscoveredSites = new List<IDiscoveredObject> { };
        internal Controls.WelcomePanel pnlWelcome;
        internal Controls.ServerPanel pnlServers;
        internal Controls.ProgressPanel pnlProgress;

        public ObservableCollection<CTaskInfo> ProgressInfo;
        object _ProgressInfoLock = new object();

        CDatabaseManager DatabaseManager;
        CCollectionManager CollectionManager;
        //CReportManager ReportManager;

        public IntPtr Handle
        {
            get { return new WindowInteropHelper(this).Handle; }
        }

        public AppWizard()
        {
            InitializeComponent();
            
            // kill previous instances of Environment Assessment Web Service that may be running
            CWebServiceManager.Kill();

            // create progress related objects
            base.TaskbarItemInfo = new TaskbarItemInfo();
            ProgressInfo = new ObservableCollection<CTaskInfo> { };
            CFunctions.EnableCollectionSynchronization(ProgressInfo, _ProgressInfoLock);

            // initialize containers
            cntTop = new Border { Name = "cntTop", Height = 110, Background = new SolidColorBrush(Colors.White), VerticalAlignment = VerticalAlignment.Top };
            DockPanel topPanel = new DockPanel() { Name = "topPanel" };
            cntTop.Child = topPanel;

            cntNav = new Border { Name = "cntNavigation", HorizontalAlignment = HorizontalAlignment.Left, Margin = new Thickness(0, 110, 0, 60), Width = 210, Background = new SolidColorBrush(Colors.LightAccent), };
            DockPanel navPanel = new DockPanel() { Name = "navPanel" }; 
            cntNav.Child = navPanel;

            cntBottom = new Border { Name = "cntBottom", Height = 60, BorderThickness = new Thickness(0, 1, 0, 0), BorderBrush = new SolidColorBrush(Colors.LightGray), Margin = new Thickness(12, 0, 12, 0), VerticalAlignment = VerticalAlignment.Bottom, };
            DockPanel btmPanel = new DockPanel() { Name = "btmPanel" };
            cntBottom.Child = btmPanel;

            cntMain = new Border { Name = "cntMain", Margin = new Thickness(210, 110, 0, 60), Background = new SolidColorBrush(Colors.White) };
            DockPanel mainPanel = new DockPanel() { Name = "mainPanel" };
            cntMain.Child = mainPanel; 
            
            // add pages
            List<string> ButtonText = new List<string>() { "< _Previous", "_Next >", "_Cancel" };

            pnlWelcome = new Controls.WelcomePanel();
            pnlWelcome.tbkTitle.Text = "Analyze your server environment";
            pnlWelcome.tbkSubTitle.Text = "Collects data from vSphere and Hyper-V.";
            pnlWelcome.tbkTerms.Text = "This program is provided as-is with no implied warranties whatsoever as to its functionality, operability, use or fitness for any purpose. We disclaim any liability regarding the use of this program, even if previously advised of such. By using this sofware you agree to these terms.";
            Pages.Add(new Page(pnlWelcome.tbkTitle.Text, pnlWelcome.tbkSubTitle.Text, new List<Control> { pnlWelcome }, ButtonText));

            pnlServers = new Controls.ServerPanel();
            pnlServers.lvServers.SetBinding(ItemsControl.ItemsSourceProperty, new Binding() { Path = new PropertyPath("CService"), NotifyOnTargetUpdated = true });
            pnlServers.lvServers.ItemsSource = DiscoveredServers;
            //[ or pnlServers.lvServers.SelectionChanged link to next and previous buttons];

            pnlServers.lgvServer.Columns.Add(new GridViewColumn { Header = "Server", DisplayMemberBinding = new Binding("Name"), Width = 140 });
            pnlServers.lgvServer.Columns.Add(new GridViewColumn { Header = "Type", DisplayMemberBinding = new Binding("Type"), Width = 120 });
            pnlServers.lgvServer.Columns.Add(new GridViewColumn { Header = "Credentials", DisplayMemberBinding = new Binding("UserName"), Width = 145 });
            //pnlServers.ComponentUpdated link to next and previous buttons

            CWorker OnServiceDiscoverWorker = new CWorker();
            OnServiceDiscoverWorker.DoWork += OnServiceDiscoverWorker_DoWork;
            OnServiceDiscoverWorker.RunWorkerCompleted += OnServiceDiscoverWorker_RunWorkerCompleted;
            Pages.Add(new Page("Server Connections", "Configure the credentials to \r\naccess vSphere and Hyper-V.", new List<Control> { pnlServers }, ButtonText,  OnServicePageValidateHandler, OnServiceDiscoverWorker));

            pnlProgress = new Controls.ProgressPanel();
            //pnlProgress.lblProgress.Content = "Collecting Data...";
            pnlProgress.lvProgress.SetBinding(ItemsControl.ItemsSourceProperty, new Binding() { Path = new PropertyPath("CTaskStatus"), NotifyOnTargetUpdated = true });
            pnlProgress.lvProgress.ItemsSource = ProgressInfo;
            pnlProgress.lgvProgress.Columns.Add(new GridViewColumn { Header = "Action", CellTemplate = (DataTemplate)FindResource("ProgressActionTemplate"), Width = 385 }); //DisplayMemberBinding = new Binding("Details")
            pnlProgress.lgvProgress.Columns.Add(new GridViewColumn { Header = "Duration", DisplayMemberBinding = new Binding("Duration"), Width = 100});
            
            CWorker OnDataCollectWorker = new CWorker();
            OnDataCollectWorker.WorkerReportsProgress = true;
            OnDataCollectWorker.DoWork += OnDataCollectWorker_DoWork;
            OnDataCollectWorker.ProgressChanged += OnDataCollectWorker_ProgressChanged;
            OnDataCollectWorker.RunWorkerCompleted += OnDataCollectWorker_RunWorkerCompleted;
            pnlProgress.pbProgress.Value = 10;
            Pages.Add(new Page("Data Collection", "Collecting data from \r\nvSphere and Hyper-V.", new List<Control> { pnlProgress }, ButtonText, null, OnDataCollectWorker));

            MainGrid.Children.Add(cntTop);
            MainGrid.Children.Add(cntNav);
            MainGrid.Children.Add(cntMain);
            MainGrid.Children.Add(cntBottom);

            // update navigation
            foreach (Control c in Navigation.Controls) { navPanel.Children.Add(c); }

            // update content for first page
            lblTitle = new Label { FontFamily = new FontFamily("Segoe UI"), FontSize = 21, Foreground = new SolidColorBrush(Colors.DarkGray), Margin = new Thickness(26, -4, 0, 0), VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left, Width = 700 };
            tbkSubTitle = new TextBlock { FontFamily = new FontFamily("Segoe UI"), FontSize = 14, Foreground = new SolidColorBrush(Colors.MediumGray), VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(-694, 40, 0, 0), };
            topPanel.Children.Add(lblTitle);
            topPanel.Children.Add(tbkSubTitle);

            int btnHeight = 30, btnWidth = 82;
            btnPrevious = new Button() { Content = ButtonText[0], Height = btnHeight, Width = btnWidth, Margin = new Thickness(460, 0, 8, 0), HorizontalAlignment = HorizontalAlignment.Right, FontSize = 14, ToolTip = "Go to previous page", Style = FindResource("WizardNextPreviousButtonStyle") as Style };
            btnNext = new Button() { Content = ButtonText[1], Height = btnHeight, Width = btnWidth, HorizontalAlignment = HorizontalAlignment.Right, FontSize = 14, Style = FindResource("WizardNextPreviousButtonStyle") as Style, ToolTip = "Go to next page" };
            btnCancelFinish = new Button() { Content = ButtonText[2], Height = btnHeight, Width = btnWidth, HorizontalAlignment = HorizontalAlignment.Right, FontSize = 14, Style = FindResource("WizardOKCancelButtonStyle") as Style, IsCancel = true, ToolTip = "Close wizard" };
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
            btnCancelFinish.Click += btnCancelFinish_Click;
            btmPanel.Children.Add(btnPrevious);
            btmPanel.Children.Add(btnNext);
            btmPanel.Children.Add(btnCancelFinish);

            // register navigation change event
            Navigation.ActivePageChanged += MainWizard_ActivePageChanged;

            // run update page for first page
            UpdatePage();
        }

        void OnServiceDiscoverWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlServers.Discovered = true;
            pnlServers.Refresh();
            UpdateControls();
        }

        void OnServiceDiscoverWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // reset collection process if we already did so once
            if (DiscoveredServers.Count == 0)
            {
                // load dependencies
                CAssemblyManager.LoadAssemblies();

                // start discovery process
                CDiscoveryManager dm = new CDiscoveryManager();
                IEnumerable<IDiscoveredObject> DiscoveredObjects = dm.GetSites();
                IEnumerable<IDiscoveredObject> sites = DiscoveredObjects.OfType<CSite>();
                DiscoveredSites.AddRange(sites);
                sites = null;
                DiscoveredObjects = null;

                DiscoveredObjects = dm.GetInventory(COptions.DiscoveryType);
                dm.Dispose();
                IEnumerable<IDiscoveredObject> servers = DiscoveredObjects.OfType<CService>();
                DiscoveredServers.AddRange(servers);
                servers = null;
                DiscoveredObjects = null;
            }
        }

        void OnServicePageValidateHandler(object sender, PageValidateEventArgs e)
        {
            if (pnlServers.lvServers.HasItems)
            {
                e.Valid = true;
            }
            else
            {
                e.Valid = false;
            }
        }

        void OnDataCollectWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancelFinish.Content = "_Finish";
            btnNext.Style = (Style)FindResource("WizardOKCancelButtonStyle");
            btnPrevious.Style = (Style)FindResource("WizardOKCancelButtonStyle");
            btnCancelFinish.Style = (Style)FindResource("WizardNextPreviousButtonStyle");
            UpdateControls();
        }

        private int ResetProgressInfo()
        {
            lock (_ProgressInfoLock)
            {
                if (ProgressInfo != null) { ProgressInfo.Clear(); }
            }
            return 0;
        }

        private void UpdateProgressInfo(List<CTaskInfo> SessionInfo)
        {
            // update progress using state information from last (and empty taskinfo object)
            string state = SessionInfo.Last<CTaskInfo>().Details;
            if (state.Length > 0) { pnlProgress.lblProgress.Content = state; }

            for (int i = 0; i < SessionInfo.Count - 1; i++)
            {
                if (SessionInfo[i].StartTime != null)
                {
                    lock (_ProgressInfoLock)
                    {
                        if (!ProgressInfo.Contains(SessionInfo[i]))
                        {
                            ProgressInfo.Add(SessionInfo[i]);
                        }
                    }
                }
            }
        }

        void OnDataCollectWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int p = e.ProgressPercentage;

            // reset progress information
            if (p == -1) { p = ResetProgressInfo(); base.TaskbarItemInfo.ProgressState = TaskbarItemProgressState.None; }
            
            // start progress counters if not done so already
            if (!pnlProgress.Running) { pnlProgress.Activate(); }

            if (e.UserState != null) {
                List<CTaskInfo> SessionInfo = (List<CTaskInfo>)e.UserState;
                if (SessionInfo.Count > 0)
                {
                    UpdateProgressInfo(SessionInfo);
                }
            }

            if (base.TaskbarItemInfo.ProgressState != TaskbarItemProgressState.Normal) { base.TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Normal; }
            base.TaskbarItemInfo.ProgressValue = (double)p / 100;

            pnlProgress.SetProgress(p);

            if ((p) == 100) { pnlProgress.Complete = true; }
        }

        void OnDataCollectWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ProgressPanelUpdate(-1);

                // run collector to get host information
                CollectionManager = new CCollectionManager();
                List<CQuery.Types> queries = new List<CQuery.Types> { }; queries.Add(new CQuery.Types(CQuery.Types.Hosts)); queries.Add(new CQuery.Types(CQuery.Types.Components));

                CollectionManager.Collect(DiscoveredSites, DiscoveredServers, queries, new CCollectionSchedule(CCollectionSchedule.RunOnce));

                // update progress panel
                int p = 10;

                // wait for collector to complete
                p = OnDataCollectWorker_WaitForCollector(p, 20, "Collecting Data...", CollectionManager);

                // removing objects from discovered server list that are in fact children of other objects
                OnDataCollectWorker_RemoveDuplicateServers();

                // run collector to get vm and datastore information
                queries = new List<CQuery.Types> { }; queries.Add(new CQuery.Types(CQuery.Types.VMs)); queries.Add(new CQuery.Types(CQuery.Types.Datastores)); queries.Add(new CQuery.Types(CQuery.Types.Events));
                CollectionManager.Collect(DiscoveredSites, DiscoveredServers, queries, new CCollectionSchedule(CCollectionSchedule.RunOnce));

                // wait for collector to complete
                p = OnDataCollectWorker_WaitForCollector(p, 70, "Collecting Data...", CollectionManager);

                if (CollectionManager.SessionManager.ErrorCount != DiscoveredServers.Count) // run if we don't have as many errors as discovered servers
                {
                    //ReportManager = new CReportManager();

                    // [tbd] create templated layout, maybe add scheduling
                    //ReportManager.RunReport(DiscoveredSites, DiscoveredServers);

                    DatabaseManager = new CDatabaseManager();
                    DatabaseManager.Export(DiscoveredSites, DiscoveredServers);

                    // wait for reporter to complete
                    //OnDataCollectWorker_WaitForReporter(p, 95, "Generating Report...", ReportManager);
                    OnDataCollectWorker_WaitForExport(p, 95, "Exporting Data...", DatabaseManager);

                    ProgressPanelUpdate(100, "Data Collection Complete.");
                }
                else { ProgressPanelUpdate(100, "Data Collection Failed."); }

            }
            catch (Exception ex) {
                CExceptionHandler.ShowExceptionDialog(ex.ToString());
            }

        }

        private int OnDataCollectWorker_WaitForExport(int p, int max, string title, CDatabaseManager databaseManager)
        {
            ProgressPanelUpdate(p, title, DatabaseManager.SessionInfo);

            do { p = ProgressPanelUpdate(p, max); }
            while (DatabaseManager != null && DatabaseManager.SessionManager != null && !DatabaseManager.SessionManager.Completed); // wait for report generation to complete
            return p;
        }

        private int OnDataCollectWorker_WaitForCollector(int p, int max, string title, CCollectionManager CollectionManager)
        {
            ProgressPanelUpdate(p, title, CollectionManager.SessionInfo);
            if (CollectionManager.SessionManager.ErrorCount != DiscoveredServers.Count) // run if we don't have as many errors as discovered servers
            {
                do { p = ProgressPanelUpdate(p, max); }
                while (CollectionManager != null && CollectionManager.SessionManager != null && !CollectionManager.SessionManager.Completed); // wait for data collection to complete
            }
            return p;
        }

        private void OnDataCollectWorker_RemoveDuplicateServers()
        {
            List<CService> servers = new List<CService> { };
            servers.AddRange(DiscoveredServers.OfType<CService>());

            servers = servers.OrderBy(o => o.Name).ToList();

            string lastServerName = "";
            int lastServerType = -1;

            for (int i = 0; i < servers.Count(); i++)
            {
                //Log.Write(servers[i].Name);
                if ((lastServerName.ToLower() == servers[i].Name.ToLower()) && (lastServerType == servers[i].Type))
                {
                    servers.RemoveAt(i); // same server name with same server type
                }
                else
                {
                    CQuery q = servers[i].Session.Queries[0];
                    for (int j = 0; j < q.Result.Count; j++)
                    {
                        CDiscoveredConfig sc = q.Result[j];
                        for (int k = 0; k < servers.Count(); k++) {
                            // server already exists as another server's child
                            if (servers[k].Name.ToLower() == sc.Name.ToLower() && (servers[k].Id != servers[i].Id)) { servers.RemoveAt(k); } } 
                    }
                }

                if (i < servers.Count)
                {
                    lastServerName = servers[i].Name;
                    lastServerType = servers[i].Type;
                }
            }

            DiscoveredServers.Clear();
            DiscoveredServers.AddRange(servers);
        }

        void ProgressPanelUpdate(int p, string status = "", List<CTaskInfo> SessionInfo = null)
        {
            if (SessionInfo == null ) { SessionInfo = new List<CTaskInfo> { }; }
            if (status.Length > 0) { SessionInfo.Add(new CTaskInfo { Details = status }); }
            Pages[Navigation.ActivePage].OnLoadAsync.ReportProgress(p, SessionInfo);
        }

        int ProgressPanelUpdate(int p, int max)
        {
            if (p < max) { p = p + 1; }
            ProgressPanelUpdate(p);
            Thread.Sleep(COptions.Display_Thread_Wait);
            return p;
        }

        void btnCancelFinish_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Goto(Navigation.ActivePage - 1);
        }

        void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Goto(Navigation.ActivePage + 1);
        }

        private void Wizard_Closed(object sender, EventArgs e)
        {
            ThreadCleanup();
        }

        void UpdateControls() {
            if (Navigation.ActivePage <= 0)
            {
                btnPrevious.IsEnabled = false;
                MainGrid.Children.Remove(cntTop);
                MainGrid.Children.Remove(cntNav);
                cntMain.Margin = new Thickness(0,0,0,60);
            }
            else
            {
                Navigation.IsEnabled = true;
                btnPrevious.IsEnabled = true;
                if (!MainGrid.Children.Contains(cntTop))
                {
                    MainGrid.Children.Add(cntTop);
                    MainGrid.Children.Add(cntNav);
                    cntMain.Margin = new Thickness(210, 110, 0, 60);
                }
            } 
            if (Navigation.ActivePage >= Pages.Count -1) { btnNext.IsEnabled = false; } else { btnNext.IsEnabled = true; }
        }

        void MainWizard_ActivePageChanged(object sender, PageChangeEventArgs e)
        {
            UpdatePage();
        }

        void UpdatePage()
        {
            ((DockPanel)cntMain.Child).Children.Clear();
            lblTitle.Content = Pages[Navigation.ActivePage].Title;
            tbkSubTitle.Text = Pages[Navigation.ActivePage].Subtitle;

            // add page specific controls
            for (int j = 0; j < Pages[Navigation.ActivePage].Controls.Count; j++)
            {
                btnPrevious.Content = Pages[Navigation.ActivePage].ButtonText[0];
                btnNext.Content = Pages[Navigation.ActivePage].ButtonText[1];
                btnCancelFinish.Content = Pages[Navigation.ActivePage].ButtonText[2];
                btnCancelFinish.Style = (Style)FindResource("WizardOKCancelButtonStyle");
                ((DockPanel)cntMain.Child).Children.Add(Pages[Navigation.ActivePage].Controls[j]);

            }
            
            UpdateControls();

            if (Pages[Navigation.PreviousPage].OnLoadAsync != null)
            {
                Pages[Navigation.PreviousPage].OnLoadAsync.Reset();
            }

            if (Pages[Navigation.ActivePage].OnLoadAsync != null) // disable next and previous buttons while page functions are running
            { 
                btnPrevious.IsEnabled = false;
                btnNext.IsEnabled = false;
                Navigation.IsEnabled = false;
                if (Pages[Navigation.PreviousPage].OnLoadAsync != null)
                {
                    Pages[Navigation.PreviousPage].OnLoadAsync.Dispose();
                }
                Pages[Navigation.ActivePage].OnLoadAsync.RunWorkerAsync(); 
            }
        }

        private void ThreadCleanup()
        {
            if (CollectionManager != null) { CollectionManager.Abort(); CollectionManager.Dispose(); } // stop collection threads
            if (DatabaseManager != null) { DatabaseManager.Abort(); DatabaseManager.Dispose(); }
            
            if (Core.ThreadManager != null) { Core.ThreadManager.Abort(); Core.ThreadManager.Dispose(); } // stop master tracking thread, can make cleaner
        }
        private void Wizard_Closing(object sender, CancelEventArgs e)
        {
            bool cancel = true;
            if (btnCancelFinish.Content.ToString() == "_Finish") {
                cancel = false;
                if (Core._ReportURI != null) {
                    CWebServiceManager.Start(Core._ReportURI);
                }
            }
            else
            {
                MessageBoxResult result = Controls.MessageBoxEx.Show(this, String.Format("Are you sure you want to quit the {0}?", Core.ProductFullName.ToLower()), Core.ProductFullName, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK) { cancel = false;}
            }
            e.Cancel = cancel;
        }

    }

}
