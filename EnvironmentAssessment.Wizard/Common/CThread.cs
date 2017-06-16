using EnvironmentAssessment.Collector;
using System;
using System.Threading;

namespace EnvironmentAssessment.Common
{

    class CThread
    {
        public Thread Worker;
        public ThreadPriority Priority;
        public Types Type;
        public bool Started = false;
        public CSession Session;
        public string ID = "";
        public bool Completed { get
            {
                if (Started && !Worker.IsAlive) { return true; }
                else { return false; }
            }
        }
        
        public class Types : IDisposable
        {
            private int _type;

            private static string[] ThreadTypes = { "Unmanaged", "Standard", "Resource", "VMware", "HyperV" };

            public const int Unmanaged = 0;
            public const int Standard = 1;
            public const int Resource = 2;
            public const int VMware = 3;
            public const int HyperV = 4;

            public Types(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                ThreadTypes = null;
            }

            public override string ToString()
            {
                return ThreadTypes[_type];
            }

            public static implicit operator int(Types x)
            {
                int i = x._type;
                return i;
            }
        }

        public CThread()
        {
            if (Type == null) { Type = new CThread.Types(Types.Unmanaged); }
            if (ID.Length == 0) { ID = CFunctions.GenerateUID(); }
        }

        public void Abort()
        {
            Worker.Abort();
        }

        public void Start()
        {
            if (Worker != null)
            {
                if (Worker.Name == null) { Worker.Name = ID; }
                Worker.Start();
                Started = true;
            }
        }

    }
}
