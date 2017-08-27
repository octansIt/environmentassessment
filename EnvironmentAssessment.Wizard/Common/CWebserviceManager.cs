using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common
{
    class CWebServiceManager
    {
        internal static void Kill()
        {
            foreach (var p in Process.GetProcessesByName(Core.ProductName + ".Web")) { p.Kill(); }
        }

        internal static void Start(string _ReportURI)
        {
            Process.Start(Core.TempPath + "\\" + Core.ProductName + ".Web.exe");
            Process.Start(Core._ReportURI);
        }
    }
}
