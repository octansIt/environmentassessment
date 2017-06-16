using EnvironmentAssessment.Collector;
using EnvironmentAssessment.Common;
using EnvironmentAssessment.Common.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Reporter
{
    class CHTMLGenerator : CReportGenerator
    {
        CSite Totals = new CSite("total", null, null, null);
        Dictionary<string, CSite> SiteList = new Dictionary<string, CSite> { };
        Dictionary<string, CSite> ServiceList = new Dictionary<string, CSite> { };
        int VIServiceCount = 0;
        int HVServiceCount = 0;
        Dictionary<string, CSite> DatacenterList = new Dictionary<string, CSite> { };
        Dictionary<string, CSite> ClusterList = new Dictionary<string, CSite> { };
        Dictionary<string, string> ClusterParentLookup = new Dictionary<string, string> { };
        Dictionary<string, string> DatacenterParentLookup = new Dictionary<string, string> { };

        public void Write(CWriter parent, string strHTMLFile, List<IDiscoveredObject> DiscoveredSites, List<IDiscoveredObject> DiscoveredServers)
        {
            CFunctions.CreateFileIfNotExist(strHTMLFile);
            TextWriter hf = new StreamWriter(strHTMLFile, false);

            string starttime = CFunctions.GetDateTime(CFunctions.DateFormatText, CFunctions.ConvertDateTime(Core._StartTime));

            hf.Write("<!doctype html>\r\n<html lang = \"en\">\r\n<head>\t<meta charset=\"UTF-8\">\r\n\t<title>Your Environment - " + Core.ProductFullName + "</title>");
            hf.Write("\t<link type=\"text/css\" rel=\"stylesheet\" href=\"includes/css/style.min.css\" />\r\n</head>");
            hf.Write("\r\n<body>\r\n\t<section class=\"header\">\r\n\t\t<section class=\"navigation\">\r\n\t\t\t<header>\r\n\t\t\t\t<div class=\"container\"><h1>Environment Assessment Toolkit</h1></div>\r\n\t\t\t</header>\r\n\t\t</section>\r\n\t</section>");
            hf.Write("\r\n\t<section class=\"main\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"content\">");
            hf.Write("\r\n\t\t\t\t<h2 class=\"title\">Your environment</h2>\r\n\t\t\t\t<ol class=\"breadcrumb\"><li class=\"breadcrumb-item active\">Overview</li></ol>");
            hf.Write("\r\n\t\t\t\t<span class=\"date\">Collected on " + starttime + "</span>");
            hf.Write("\r\n\t\t\t\t<div class=\"inner\"></div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>");
            hf.Write("\r\n\t<footer>\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"disclaimer\">");
            hf.Write("\r\n\t\t\t<p>Data collected on " + starttime + "  by the Environment Assessment Toolkit, " + Core.ProductCopyright + ". All trademarks are the property of their respective owners. <br>The information provided is not guaranteed to be accurate in any way, or fit for any purpose whatsoever.We make no warranties, express or implied, in this document.</p>");
            hf.Write("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</footer>\r\n\t<script>json_url = '" + strHTMLFile.Replace(Core.TempPath + "\\","").Replace("html","json") + "';</script><script type=\"text/javascript\" src=\"includes/js/app.min.js\"></script>\r\n</body>\r\n</html>");

            hf.Close();
            parent.Progress.Status = new CTaskInfo.State(CTaskInfo.State.Success);
            parent.Completed = true;
        }
    }
}