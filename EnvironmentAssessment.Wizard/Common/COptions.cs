using EnvironmentAssessment.Common.Inventory;
using System;
using System.Collections.Generic;

namespace EnvironmentAssessment.Common
{
    public class COptions
    {
        internal class Precision : IDisposable
        {
            private int _type;

            private static string[] PrecisionTypes = { "Low", "Medium", "High" };

            public const int Low = 0;
            public const int Medium = 1;
            public const int High = 2;

            public Precision(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                PrecisionTypes = null;
            }

            public override string ToString()
            {
                return PrecisionTypes[_type];
            }

            public static implicit operator int(Precision x)
            {
                int i = x._type;
                return i;
            }
        }

#if DEBUG
        public const int Verbosity = Log.Verbosity.Everything;
#else
        public const int Verbosity = Log.Verbosity.Verbose;
#endif

        public const int Thread_Max_Total = 128;
        public const int Thread_Wait = 500; // phase out, use event handling instead

        public const int Thread_Max_VI_Per_Instance = 16;
        public const int VI_Thread_Wait = 100;
        public const int VI_Timeout = 100000;
        public const int VI_Login_Timeout = 300000;
        public const int VI_Datastore_Search_Level = 0;

        public const int Thread_Max_HV_Per_Instance = 16;
        public const int HV_Thread_Wait = WMI_Thread_Wait;

        public const int VBR_Thread_Wait = WMI_Thread_Wait;

        public const int WMI_Thread_Wait = 100;

        public const int Session_Thread_Max = 8;
        public const int Session_Thread_Wait = 250; // phase out, use event handling instead

        public const int Display_Thread_Wait = 500; // wait time between GUI display updates for progress counters

        public const int Connection_Timeout = 5000;

        public const int Preciseness = Precision.Medium; // affects if we scan for actual thin/thick disk sizes

        public const int DiscoveryType = Collector.CDiscoveryType.WithPortScan;
        public static List<CServiceType> DiscoverServers = new List<CServiceType> { new CServiceType(CServiceType.VCenterServer), new CServiceType(CServiceType.ESXServer), new CServiceType(CServiceType.HYVServer) }; //new CServiceType(CServiceType.VBRServer) };

    }
}
