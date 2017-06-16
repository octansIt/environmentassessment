using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;

namespace EnvironmentAssessment.Controls
{
    using Common;

    /// <summary>
    /// Interaction logic for ServerEditDialog.xaml
    /// </summary>
    /// 

    using Common.Inventory;

    public partial class ServerEditDialog : Controls.Dialog
    {
        public Modes Mode { get; set; }
        private IList<IDiscoveredObject> ObjectCollection;
        private IList<IDiscoveredObject> ObjectSelection;
        TextBox tbServiceName,tbUsername;
        ComboBox cbServiceType;
        PasswordBox pbPassword;

        public IntPtr Handle
        {
            get { return new WindowInteropHelper(this).Handle; }
        }

        public class Modes : IDisposable
        {
            private int _mode;

            public static string[] DialogTypes = { "Add Server", "Edit Server" };

            public const int Add = 0;
            public const int Edit = 1;

            public Modes(int t = -1)
            {
                _mode = t;
            }

            public void Dispose()
            {
                DialogTypes = null;
            }

            public override string ToString()
            {
                return DialogTypes[_mode];
            }

            public static implicit operator int(Modes x)
            {
                int i = x._mode;
                return i;
            }
        }

        public ServerEditDialog(int m = ServerEditDialog.Modes.Add, IList<IDiscoveredObject> ItemsCollection = null, IList<IDiscoveredObject> ItemsSelection = null)
        {
            InitializeComponent();
            Mode = new Modes(m);
            Title = Modes.DialogTypes[Mode];
            tbkServerEdit.Text = "Add servers to collect data from with the " + Core.ProductFullName + ", using credentials to read the data.";

            tbServiceName = new TextBox {};
            tbServiceName.TextChanged += tbServiceName_TextChanged;
            tbServiceName.Style = (Style)FindResource("WizardTextBoxStyle");
            Label lblServiceName = new Label { Content = "DNS name or IP address:", Target=tbServiceName };
            cbServiceType = new ComboBox {};
            cbServiceType.ItemsSource = COptions.DiscoverServers;
            Label lblServiceType = new Label { Content = "Server type:", Target=cbServiceType};
            tbUsername = new TextBox {};
            tbUsername.TextChanged += tbUsername_TextChanged;
            tbUsername.Style = (Style)FindResource("WizardTextBoxStyle");
            Label lblUsername = new Label { Content = "Username:", Target = tbUsername};
            pbPassword = new PasswordBox { };
            Label lblPassword = new Label { Content = "Password:", Target = pbPassword};
            List<Control> ServerEditControls = new List<Control> { lblServiceName, tbServiceName, lblServiceType, cbServiceType, lblUsername, tbUsername, lblPassword, pbPassword };

            ObjectCollection = ItemsCollection;
            ObjectSelection = ItemsSelection;
            if (ObjectSelection != null && Mode == Modes.Edit)
            {
                if (ObjectSelection.Count() == 1)
                {
                    tbServiceName.Text = ((CService)ObjectSelection.First()).Name;
                    cbServiceType.Text = ((CService)ObjectSelection.First()).Type.ToString();
                    tbUsername.Text = ((CService)ObjectSelection.First()).UserName;
                    FocusManager.SetFocusedElement(this, tbServiceName);
                    Keyboard.Focus(tbUsername);
                }
                if (ObjectSelection.Count() > 1)
                {
                    Title = "Edit Servers";
                    tbServiceName.IsEnabled = false;
                    cbServiceType.IsEnabled = false;
                    FocusManager.SetFocusedElement(this, tbUsername);
                    Keyboard.Focus(tbUsername);
                }
            }
            else
            {
                cbServiceType.Text = COptions.DiscoverServers[0].ToString();
                FocusManager.SetFocusedElement(this, tbServiceName);
                Keyboard.Focus(tbUsername);
            }
            
            foreach(Control control in ServerEditControls)
            {
                control.Height = 25;
                if (control.GetType().ToString() == "System.Windows.Controls.Label") { control.Margin = new Thickness(-2, 10, 0, 0); }
                if (control.GetType().ToString() == "System.Windows.Controls.TextBox" || control.GetType().ToString() == "System.Windows.Controls.PasswordBox") { control.VerticalContentAlignment = System.Windows.VerticalAlignment.Center; }
                DockPanel.SetDock(control, Dock.Top);
                pnlMain.Children.Add(control);
            }

        }

        void tbUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormValidate();
        }

        void tbServiceName_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormValidate();
        }
        
        void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (SaveChanges()) { this.Close(); }
        }

        private void FormValidate()
        {
            if ((tbServiceName.Text.Trim().Length == 0))
            {
                btnOK.IsEnabled = false;
            }
            else
            {
                btnOK.IsEnabled = true;
            }
        }

        private bool ObjectValidates(Common.Inventory.CService ModifiedObject)
        {
            bool valid = false;
            if (ModifiedObject != null) { if (ModifiedObject.IP != null) { valid = true; } }
            if (!valid) { MessageBoxEx.Show(this, "Server \"" + tbServiceName.Text + "\" does not resolve to a valid IP address. \r\nVerify server connectivity and that DNS is configured correctly.", Core.ProductName, MessageBoxButton.OK, MessageBoxImage.Error); }
            return valid;
        }

        private bool ObjectUnique(Common.Inventory.CService ModifiedObject)
        {
            bool unique = true;
            foreach (CService server in ObjectCollection)
            {
                if (server.Name == tbServiceName.Text.Trim())
                {
                    unique = false;
                }
            }
            if (!unique) { MessageBoxEx.Show(this, "Server object \"" + tbServiceName.Text + "\" has been already added to the list. \r\nPlease edit the existing entry.", Core.ProductName, MessageBoxButton.OK, MessageBoxImage.Error); }
            return unique;
        }

        private bool SaveChanges()
        {
            bool saved = false;
            Cursor PreviousCursor = Mouse.OverrideCursor;
            Mouse.OverrideCursor = Cursors.Wait;
            if (ObjectSelection != null && Mode == Modes.Edit)
            {
                if (ObjectSelection.Count() > 1)
                {
                    foreach (CService server in ObjectSelection)
                    {
                        server.UserName = tbUsername.Text.Trim();
                        server.UserPassword = pbPassword.Password;
                    }
                    saved = true;
                }
                else
                {
                    foreach (CService server in ObjectSelection)
                    {
                        // actually only runs once
                        CService ModifiedObject = new CService(tbServiceName.Text.Trim(), (int)(new CServiceType(cbServiceType.Text)), tbUsername.Text.Trim(), pbPassword.Password);
                        bool unique;
                        if (server.Name == tbServiceName.Text.Trim()) { unique = true; } // object name has not changed
                        else { unique = ObjectUnique(ModifiedObject); } // if name has changed check if it still is unique
                        if (ObjectValidates(ModifiedObject) && unique)
                        {
                            server.Name = tbServiceName.Text.Trim();
                            server.IP = ModifiedObject.IP;
                            server.Type = new CServiceType(cbServiceType.Text);
                            server.UserName = ModifiedObject.UserName;
                            server.UserPassword = ModifiedObject.UserPassword;
                        }
                        saved = true;
                    }

                }
            }
            else
            {
                CService NewObject = new CService(tbServiceName.Text, (int)(new CServiceType(cbServiceType.Text)), tbUsername.Text, pbPassword.Password);
                if (ObjectValidates(NewObject) && ObjectUnique(NewObject))
                {
                    ObjectCollection.Add(NewObject);
                    saved = true;
                }
            }
            Mouse.OverrideCursor = PreviousCursor;
            return saved;
        }

        void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
