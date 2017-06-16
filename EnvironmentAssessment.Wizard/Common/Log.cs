using System;
using System.IO;
using System.Diagnostics;

namespace EnvironmentAssessment.Common
{
    public class Log
    {
        public static string TempPath = Core.TempPath;
        private static Object _LogWriterLock = new Object();

        internal static string ProductName = Core.ProductName;
        internal static string ProductFullName = Core.ProductFullName;

        internal class Verbosity
        {
            // verbosity -1 = off, 0 = general, 1 = fatal, 2 = error, 3 = warn, = 4 info, 6 = debug, 7 = everything
            internal const int General = 0;
            internal const int FatalError = 1;
            internal const int Error = 2;
            internal const int Warning = 3;
            internal const int Information = 4;
            internal const int Verbose = 5;
            internal const int Debug = 6;
            internal const int Everything = 7;
        }

        // global verbosity rules will be applied

        public static void Write(string data, int verbosity = Verbosity.Verbose, int tid = 0)
        {

            if ((COptions.Verbosity != 0) && (verbosity <= COptions.Verbosity))
            {
                // create temp path on first write
                CFunctions.CreateFolderIfNotExist(TempPath);

                // create log file on first write
                string strLogFile = TempPath + "\\" + ProductName + ".log";
                CFunctions.CreateFileIfNotExist(strLogFile);

                if (tid == 0) { tid = System.Threading.Thread.CurrentThread.ManagedThreadId; }
                Process currentProcess = Process.GetCurrentProcess();
                int pid = currentProcess.Id;

                // write data to log
                // could make faster by turning into in-memory queueing system that then writes to log
                lock (_LogWriterLock)
                {
                    TextWriter logFile = new StreamWriter(strLogFile, true);
                    logFile.WriteLine("[" + CFunctions.GetDateTime(CFunctions.DateFormatLogging) + "] <" + pid + ":" + tid + "> " + data);
                    logFile.Close();
                }

            }
        }
    }
}
