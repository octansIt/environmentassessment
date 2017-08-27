using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;

namespace EnvironmentAssessment.Controls
{
    /// <summary>
    /// Interaction logic for ExceptionDialog.xaml
    /// </summary>
    /// 

    using Common.Inventory;
    using System.Diagnostics;
    using System.Windows.Media;

    public partial class ExceptionDialog : Controls.Dialog
    {
        internal bool Expanded = false;

        public IntPtr Handle
        {
            get { return new WindowInteropHelper(this).Handle; }
        }
        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Core._AllowErrorReporting = (this.cbkUpload.IsChecked == true);
            this.Close();
        }

        private void lblMoreInfo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(Core.TempPath + "\\" + Core.ProductName + ".log");
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        public ExceptionDialog(string ExceptionDetails)
        {
            InitializeComponent();
            this.cbkUpload.IsChecked = Core._AllowErrorReporting;
            this.Title = Core.ProductFullName;
            if (ExceptionDetails != null) { this.tbkDetails.Text = ExceptionDetails; }
            this.tbkDetails.TextWrapping = TextWrapping.Wrap;
            this.tbkException.Text = "An unexpected exception occurred when running\r\nthe " + Core.ProductFullName + ".";
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            Expand();
        }

        private void Expand()
        {
            if (!Expanded)
            {
                btnClose.Background = new SolidColorBrush(Wizard.Colors.LightLightGray);
                btnDetails.Visibility = Visibility.Collapsed;
                bdDetails.Visibility = Visibility.Visible;
                btmGrid.Margin = new Thickness(-8, -38, -8, 6);
                this.Height = 400;
                this.Top = this.Top - 100;
            }
        }
    }
}
