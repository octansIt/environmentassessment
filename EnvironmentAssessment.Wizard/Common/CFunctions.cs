using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Data;

namespace EnvironmentAssessment.Common
{
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

            if (format == DateFormatNumeric)
            {
                result = strYear + strMonth + strDay + strHour + strMinute + strSecond;
            }
            else if (format == DateFormatLogging)
            {
                result = strYear + "." + strMonth + "." + strDay + " " + strHour + ":" + strMinute + ":" + strSecond;
            }
            else if (format == DateFormatText)
            {
                result = strYear + "-" + strMonth + "-" + strDay + " at " + strHour + ":" + strMinute + ":" + strSecond;
            }

            return result;
        }

        internal static void CreateFolderIfNotExist(string folder)
        {
            if (!System.IO.Directory.Exists(folder)) { System.IO.Directory.CreateDirectory(folder); }
        }

        public static string StringReplace(params string[] list)
        {
            string source = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                source = source.Replace("{" + (i - 1) + "}", list[i]);
            }
            return source;
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
