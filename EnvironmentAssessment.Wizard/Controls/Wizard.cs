using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace EnvironmentAssessment.Controls
{
    public class Wizard : Window
    {
        public static List<Page> Pages = new List<Page>();
        public static PageSelector Navigation = new PageSelector();
        
        public static class Colors {
            public static Color Transparent = System.Windows.Media.Colors.Transparent;
            public static Color White = System.Windows.Media.Colors.White;
            public static Color LightGray = (Color)ColorConverter.ConvertFromString("#e6e6e6");
            public static Color LightLightGray = (Color)ColorConverter.ConvertFromString("#FFF0F0F0");
            public static Color MediumGray = (Color)ColorConverter.ConvertFromString("#999999");
            public static Color DarkGray = (Color)ColorConverter.ConvertFromString("#666666");
            public static Color LightAccent = (Color)ColorConverter.ConvertFromString("#e6f1f1");
            public static Color MediumAccent = (Color)ColorConverter.ConvertFromString("#74abaf");
            public static Color DarkAccent = (Color)ColorConverter.ConvertFromString("#468686");
        }

        public class Page : IDisposable  {

            public List<Control> Controls = new List<Control>();
            public string Title;
            public string Subtitle;
            public List<string> ButtonText;
            public Common.CWorker OnLoadAsync;
            public Common.CWorker OnLeaveAsync;
            public event System.EventHandler<PageValidateEventArgs> PageValidate;
            public event System.EventHandler PageUpdated;

            public Page (string PageTitle, string PageSubtitle, List<Control> PageControls, List<string> PageButtons, EventHandler<PageValidateEventArgs> PageValidateEventHandler = null, Common.CWorker OnPageLoadAsyncWorker = null, Common.CWorker OnPageLeaveAsyncWorker = null)
            {

                Title = PageTitle.Trim();
                Subtitle = PageSubtitle.Trim();
                ButtonText = PageButtons;

                foreach(Control c in PageControls) {
                    Controls.Add(c);
                }

                OnLeaveAsync = OnPageLeaveAsyncWorker;
                OnLoadAsync = OnPageLoadAsyncWorker;
                PageValidate = PageValidateEventHandler;

                int NavItemHeight = 24, NavItemWidth = 210, NavHeightOffset = -24, NavWidthOffset = 0;
                List<SolidColorBrush> NavColor = PageSelector.InactiveNavColor;
                if (Navigation.Controls.Count == 0) { Navigation.ActivePage = 0; NavColor = PageSelector.ActiveNavColor; NavWidthOffset = NavItemWidth; };
                Label pageLabel = new Label { Name = Regex.Replace(PageTitle, "[^0-9a-zA-Z]+", "_"), Content = PageTitle, FontFamily = new FontFamily("Segoe UI"), FontSize = 14, Foreground = NavColor[0], Background = NavColor[1], Width = NavItemWidth, Height = NavItemHeight, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left, Margin = new Thickness(NavWidthOffset-NavItemWidth, Navigation.Controls.Count * NavItemHeight + NavHeightOffset, 0, 0), Padding = new Thickness(22, 2, 0, 4) };
                if (Pages.Count == 0) { pageLabel.Visibility = Visibility.Hidden; } // hide navigation item for first page
                else { pageLabel.Visibility = Visibility.Visible; }
                pageLabel.MouseLeftButtonDown += Navigation.Click;
                Navigation.Controls.Add(pageLabel);    

            }

            public virtual void OnPageUpdated()
            {
                if (PageUpdated != null)
                {    
                    PageUpdated(this, new EventArgs());
                }
            }

            public virtual bool OnValidate()
            {
                if (PageValidate != null)
                {
                    PageValidateEventArgs e = new PageValidateEventArgs();
                    PageValidate(this, e);
                    return e.Valid;
                }
                return true;
            }

            public void Dispose ()
            {
                Controls = null;
                Title = null;
                Subtitle = null;
            }
        }

        public class PageChangeEventArgs : EventArgs
        {
            //public int PreviousPage { get; set; }
            //public int ActivePage { get; set; }
        }

        public class PageValidateEventArgs  : EventArgs
        {
            public bool Valid { get; set; }
        }

        public class PageSelector
        {
            public static List<SolidColorBrush> InactiveNavColor = new List<SolidColorBrush> { new SolidColorBrush(Colors.DarkAccent), new SolidColorBrush(Colors.LightAccent) };
            public static List<SolidColorBrush> ActiveNavColor = new List<SolidColorBrush> { new SolidColorBrush(Colors.White), new SolidColorBrush(Colors.MediumAccent) };
                
            public List<Control> Controls = new List<Control>();

            public event EventHandler<PageChangeEventArgs> ActivePageChanged;
            internal static int _activepage;
            internal static int _previouspage;
            public int ActivePage
            {
                get
                {
                    return _activepage;
                }
                set
                {
                    _previouspage = _activepage;
                    _activepage = value;
                    OnActivePageChanged();
                }
            }

            public int PreviousPage
            {
                get
                {
                    return _previouspage;
                }
            }

            public bool IsEnabled { get; set; }


            public virtual void OnActivePageChanged()
            {
                PageChangeEventArgs e = new PageChangeEventArgs { };
                if (ActivePage != null && ActivePageChanged != null) { ActivePageChanged(this, e); };
            }

            public PageSelector()
            {
                IsEnabled = true;
            }

            public void Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                Navigation.Goto(sender.ToString().Split(':')[1].Trim());
            }

            public void Goto(int NextPage)
            {
                if (Pages[ActivePage].OnValidate() == true && Navigation.IsEnabled)
                {
                    if (Pages[ActivePage].OnLeaveAsync != null) { Pages[ActivePage].OnLeaveAsync.RunWorkerAsync(); }
                    Controls[ActivePage].Foreground = InactiveNavColor[0];
                    Controls[ActivePage].Background = InactiveNavColor[1];
                    Controls[NextPage].Foreground = ActiveNavColor[0];
                    Controls[NextPage].Background = ActiveNavColor[1];
                    ActivePage = NextPage;
                }
            }

            public void Goto(string PageTitle)
            {
                for(int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i].Name == Regex.Replace(PageTitle, "[^0-9a-zA-Z]+", "_")) 
                    {
                        Goto(i);
                    }
                }
            }

        }
    }
}
