using EnvironmentAssessment.Common;
using EnvironmentAssessment.Controls;
using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace EnvironmentAssessment
{
    public class CExceptionHandler
    {
        internal static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            TrapUnhandledException(e.ExceptionObject.ToString());
        }

        internal static void UnhandledExceptionTrapper(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            TrapUnhandledException(e.Exception.ToString());
        }

        internal static void TrapUnhandledException(string e)
        {
            ShowExceptionDialog(e);
        }
        
        internal static void ShowExceptionDialog(string e)
        {
            Log.Write("{ " + e + " }");

            string appinfo = "Executable: " + Core._Executable.Substring(Core._Executable.LastIndexOf('\\') + 1).ToLower();
            appinfo += "\r\nArguments: " + Core._Arguments;
            appinfo += "\r\nVersion: " + Core.ProductVersion;
            appinfo += "\r\nBuild: " + Core.ProductBuild;

            OperatingSystem os = Environment.OSVersion;
            appinfo += "\r\nOS version: " + os.VersionString + ", OS service pack: " + os.ServicePack;
            appinfo += "\r\nUser culture: " + Thread.CurrentThread.CurrentCulture.Name + ", OS culture: " + CultureInfo.InstalledUICulture;

            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                    ExceptionDialog dlgException = new ExceptionDialog(appinfo + "\r\n\r\n--- Begin stack trace ---\r\n   " + e);
                    dlgException.ShowDialog();
            }));
            Environment.Exit(1);
        }

        public class Exceptions
        {
            public class LZMAInvalidParameterEx : ApplicationException
            {
                public LZMAInvalidParameterEx() : base("LZMA invalid parameter") { }
            }
            public class LZMAInvalidDataEx : ApplicationException
            {
                public LZMAInvalidDataEx() : base("LZMA data Error") { }
            }
        }
    }
}
