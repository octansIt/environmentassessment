using System;

namespace EnvironmentAssessment.Common
{
    public class CReportFormat : IDisposable
    {
        private int _format;
        private static string[] ReportFormats = { "JSON", "CSV", "HTML", "PDF" };
        public const int JSON = 0;
        public const int CSV = 1;
        public const int HTML = 2;
        public const int PDF = 3;

        public CReportFormat(int s = -1)
        {
            _format = s;
        }

        public void Dispose()
        {
            ReportFormats = null;
        }

        public override string ToString()
        {
            return ReportFormats[_format];
        }

        public static implicit operator int(CReportFormat x)
        {
            int i = x._format;
            return i;
        }
    }
    
    public class CReportStyle : IDisposable
    {
        private int _style;
        private static string[] ReportStyles = { "Default Style" };
        public const int DefaultStyle = 0;

        public CReportStyle(int s = -1)
        {
            _style = s;
        }

        public void Dispose()
        {
            ReportStyles = null;
        }

        public override string ToString()
        {
            return ReportStyles[_style];
        }

        public static implicit operator int(CReportStyle x)
        {
            int i = x._style;
            return i;
        }
    }

    public class CReportTemplate
    {
        public CReportStyle Style;
        public CReportFormat Format;
    }
}
