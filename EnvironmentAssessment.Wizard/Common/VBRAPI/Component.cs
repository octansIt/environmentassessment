using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.VBRAPI
{
    class Component
    {
        public class CComponentType : IDisposable
        {
            private int _type;

            private static string[] ComponentTypes = { "Backup Proxy", "Tape Proxy", "Guest Interaction Proxy", "CDP Proxy", "File Proxy", "Backup Repository", "WAN Accelerator", "Mount Server", "Gateway Server", "Cloud Gateway" };

            public const int BackupProxy = 0;
            public const int TapeProxy = 1;
            public const int GuestInteractionProxy = 2;
            public const int CDPProxy = 3;
            public const int FileProxy = 4;
            public const int BackupRepository = 5;
            public const int WANAccelerator = 6;
            public const int MountServer = 7;
            public const int RepositoryGateway = 8;
            public const int CloudGateway = 9;

            public CComponentType(string s = "")
            {
                _type = Array.IndexOf(ComponentTypes, s);
            }
            public CComponentType(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                ComponentTypes = null;
            }

            public override string ToString()
            {
                return ComponentTypes[_type];
            }

            public static implicit operator int(CComponentType x)
            {
                int i = x._type;
                return i;
            }
        }
    }
}
