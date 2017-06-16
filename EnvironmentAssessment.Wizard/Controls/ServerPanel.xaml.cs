using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EnvironmentAssessment.Controls
{
    /// <summary>
    /// Interaction logic for ServerPanel.xaml
    /// </summary>
    /// 
    using Common.Inventory;

    public partial class ServerPanel : UserControl
    {
        public GridView lgvServer = new GridView() { AllowsColumnReorder = false };
        ServerEditDialog dlgServerEdit;
        public bool Discovered = false;

        public ServerPanel()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            lblServers.Content = "Please add the servers you wish to collect data from:";
            lvServers.View = lgvServer;
            lvServers.SelectionChanged += lvServers_SelectionChanged;
            lvServers.MouseDoubleClick += lvServers_MouseDoubleClick;
            lvServers.KeyDown+=lvServers_KeyDown;
            UpdateButtons();
        }

        void lvServers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (lvServers.SelectedItems.Count >= 1)
                {
                    ShowEditDialog(new ServerEditDialog.Modes(ServerEditDialog.Modes.Edit));
                }
            }
        }

        void UpdateButtons()
        {
            if (!Discovered) { btnAdd.IsEnabled = false; }
            else {
                btnAdd.IsEnabled = true; 
                bdLoading.Visibility = Visibility.Collapsed;
            }
            if (lvServers.SelectedItems.Count == 0)
            {
                btnEdit.IsEnabled = false;
                btnRemove.IsEnabled = false;
            }
            else
            {
                btnEdit.IsEnabled = true;
                btnRemove.IsEnabled = true;
            }
        }
        void lvServers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateButtons();
        }

        void lvServers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvServers.SelectedItems.Count == 1)
            {
                ShowEditDialog(new ServerEditDialog.Modes(ServerEditDialog.Modes.Edit));
            }
        }

        public void Refresh()
        {
            lvServers.Items.Refresh();
            UpdateButtons();
        }

        void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // removing items from source list and refreshing control after
            // might be slightly worse for performance instead of different approach
            List<IDiscoveredObject> servers = lvServers.Items.SourceCollection as List<IDiscoveredObject>;
            foreach(IDiscoveredObject item in lvServers.SelectedItems)
            {
                servers.Remove(item);
                item.Dispose();
            }
            this.Refresh();
        }

        void ShowEditDialog(ServerEditDialog.Modes m)
        {
            List<IDiscoveredObject> Items = lvServers.Items.SourceCollection as List<IDiscoveredObject>;
            if (m == ServerEditDialog.Modes.Edit)
            {
                List<IDiscoveredObject> SelectedItems = lvServers.SelectedItems.OfType<IDiscoveredObject>().ToList();
                dlgServerEdit = new ServerEditDialog(m, Items, SelectedItems) { Owner = Core._App.Windows[0] };
                dlgServerEdit.Closed += dlgServerEdit_Closed;
                dlgServerEdit.Show();
            }
            else if (m == ServerEditDialog.Modes.Add)
            {
                dlgServerEdit = new ServerEditDialog(m, Items) { Owner = Core._App.Windows[0] };
                dlgServerEdit.Closed += dlgServerEdit_Closed;
                dlgServerEdit.Show();
            }
        }

        void dlgServerEdit_Closed(object sender, EventArgs e)
        {
            lvServers.Items.Refresh();
        }
        void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            ShowEditDialog(new ServerEditDialog.Modes(ServerEditDialog.Modes.Edit));
        }

        void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ShowEditDialog(new ServerEditDialog.Modes(ServerEditDialog.Modes.Add));
        }
    }
}
