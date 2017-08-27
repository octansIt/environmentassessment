using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Data;

namespace EnvironmentAssessment.Common
{
    public static class CDataUnitType
    {
        public const int Byte = 0;
        public const int KiB = 1;
        public const int MiB = 2;
        public const int GiB = 3;
        public const int TiB = 4;
        public const int PiB = 5;
    }

    public static class CFunctions
    {
        public const int DateFormatNumeric = 0;
        public const int DateFormatLogging = 1;
        public const int DateFormatText = 2;

        public static string GenerateUID()
        {
            return System.Guid.NewGuid().ToString().Replace("-", String.Empty);
        }

        public static void CreateFileIfNotExist(string file)
        {
            if (!File.Exists(file)) { FileStream lf = File.Create(file); lf.Close(); }
        }

        internal static DateTime ConvertDateTime(string s)
        {
            return new DateTime(Int16.Parse(s.Substring(0, 4)), Int16.Parse(s.Substring(4, 2)), Int16.Parse(s.Substring(6, 2)), Int16.Parse(s.Substring(8, 2)), Int16.Parse(s.Substring(10, 2)), Int16.Parse(s.Substring(12, 2)));
        }

        internal static string GetDateTime(int format = 0, DateTime dt = default(DateTime))
        {
            string result = "";

            if (dt == default(DateTime)) { dt = DateTime.Now; }
            string strYear = dt.Year.ToString();
            string strMonth = (100 + dt.Month).ToString().Substring(1, 2);
            string strDay = (100 + dt.Day).ToString().Substring(1, 2);
            string strHour = (100 + dt.Hour).ToString().Substring(1, 2);
            string strMinute = (100 + dt.Minute).ToString().Substring(1, 2);
            string strSecond = (100 + dt.Second).ToString().Substring(1, 2);
            string strTimeOfDay = dt.TimeOfDay.ToString();
            //string strTicks = (10000000 + dt.Ticks).ToString().Substring(1, 7);

            if (format == DateFormatNumeric)
            {
                result = strYear + strMonth + strDay + strHour + strMinute + strSecond;
            }
            else if (format == DateFormatLogging)
            {
                result = strYear + "." + strMonth + "." + strDay + " " + strTimeOfDay;
            }
            else if (format == DateFormatText)
            {
                result = strYear + "-" + strMonth + "-" + strDay + " at " + strHour + ":" + strMinute + ":" + strSecond;
            }

            return result;
        }

        internal static long ConvertDataUnit(long? data, int srctype, int trgtype)
        {
            long result = 0;
            if (data == null) { return result; }
            double srcdata = (double)data * Math.Pow(1024, srctype);
            double trgdata = srcdata / Math.Pow(1024, trgtype);
            result = (Int64)Math.Round(trgdata,MidpointRounding.AwayFromZero);
            return result;
        }

        internal static void CreateFolderIfNotExist(string folder)
        {
            if (!System.IO.Directory.Exists(folder)) { System.IO.Directory.CreateDirectory(folder); }
        }

        public static string StringReplace(params string[] list)
        {
            string result = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                result = result.Replace("{" + (i - 1) + "}", list[i]);
            }
            return result;
        }

        public static string EscapeJson(string s)
        {
            if (s != null) {
                StringBuilder result = new StringBuilder();
                char[] chars = s.ToCharArray();
                string r;
                foreach (char c in chars)
                {
                    switch (c)
                    {
                        case '"':
                            r = "\\\"";
                            break;
                        case '\\':
                            r = "\\\\";
                            break;
                        case '\b':
                            r = "\\\b";
                            break;
                        case '\f':
                            r = "\\\f";
                            break;
                        case '\n':
                            r = "\\\n";
                            break;
                        case '\r':
                            r = "\\\r";
                            break;
                        case '\t':
                            r = "\\\t";
                            break;
                        default:
                            if (char.IsControl(c)) { r = "\\u" + ((int)c).ToString("x4"); }
                            else { r = "" + c; }
                            break;
                    }
                    result.Append(r);
                }
                return result.ToString();
            }
            else { return ""; }
        }

        public static string StringJoin(string suffix = ";", List<string> list = null)
        {
            string result = "";
            if (list != null) { result = String.Join(suffix, list); }
            return result;
        }

        public static string ToStringNz(this object value)
        {
            return (value ?? string.Empty).ToString();
        }

        public static void EnableCollectionSynchronization(IEnumerable collection, object lockObject)
        {
            // Equivalent to .NET 4.5:
            // BindingOperations.EnableCollectionSynchronization(collection, lockObject);
            MethodInfo method = typeof(BindingOperations).GetMethod("EnableCollectionSynchronization", new Type[] { typeof(IEnumerable), typeof(object) });
            if (method != null)
            {
                method.Invoke(null, new object[] { collection, lockObject });
            }
        }
    }
}
