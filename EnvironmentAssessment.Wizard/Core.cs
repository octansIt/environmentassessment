/* Copyright 2017, Johan Huttenga
 
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

using System;
using System.Reflection;
using EnvironmentAssessment.Common;
using System.Threading;
using System.Globalization;
using System.Net;

namespace EnvironmentAssessment
{
    class Core
    {
        public static string ProductName = Assembly.GetEntryAssembly().GetName().Name;
        public static string ProductCopyright = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetEntryAssembly(), typeof(AssemblyCompanyAttribute), false)).Company;
        public static string ProductFullName = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetEntryAssembly(), typeof(AssemblyTitleAttribute), false)).Title;
        public static string ProductVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
        public static string ProductBuild = ((AssemblyInformationalVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetEntryAssembly(), typeof(AssemblyInformationalVersionAttribute), false)).InformationalVersion;
        public static string TempPath = System.IO.Path.GetTempPath() + ProductName;
        public static string IncludesPath = Core.TempPath + "\\includes";
        public static string DatabasePath = Core.TempPath + "\\data";

        public static CThreadManager ThreadManager = new CThreadManager();
        public static App _App;
        internal static string _StartTime;
        internal static string _Arguments;
        internal static string _Executable = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace('/', '\\');
        internal static bool _HasException = false;

        internal static string _ReportURI;

        [STAThread]
        public static void Main(string[] args)
        {
            //#if !DEBUG
            System.AppDomain.CurrentDomain.UnhandledException += CExceptionHandler.UnhandledExceptionTrapper;
            //#endif
            _StartTime = CFunctions.GetDateTime();

            foreach (string arg in args)
            {
                _Arguments += arg + ", ";
            }

            Log.Write(new String('=', 78), -2);
            Log.Write("{", -2);
            Log.Write("  Executable: " + _Executable.Substring(_Executable.LastIndexOf('\\') + 1).ToLower(), -2);

            Log.Write("  Arguments: " + _Arguments, -2);
            Log.Write("  Version: " + ProductVersion, -2);
            Log.Write("  Build: " + ProductBuild, -2);

            OperatingSystem os = Environment.OSVersion;
            Log.Write("  OS version: " + os.VersionString + ", OS service pack: " + os.ServicePack, -2);
            Log.Write("  User culture: " + Thread.CurrentThread.CurrentCulture.Name + ", OS culture: " + CultureInfo.InstalledUICulture, 2);
            Log.Write("}", -2);

            // ignore invalid SSL errors, warn user in logs (might move up higher in code later on)
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback += delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                if (sslPolicyErrors != System.Net.Security.SslPolicyErrors.None)
                { Log.Write("Warning: A non-critical SSL error occurred: " + sslPolicyErrors); }
                return true; // **** Always accept
            };

            if (args != null && args.Length > 0)
            {
            }
            else
            {
                _App = new App();
                _App.InitializeComponent();
                _App.Run();
            }
        }
    }
}
