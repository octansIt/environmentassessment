using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.VbrApi
{
    class Job
    {
        public class CJobType : IDisposable
        {
            private int _type;

            private static string[] Values = { "Backup Job", "Backup Copy Job", "Replica Job", "File To Tape Job", "Backup To Tape Job", "File Copy Job", "VM Copy Job" };

            public const int BackupJob = 0;
            public const int BackupCopyJob = 1;
            public const int ReplicaJob = 2;
            public const int FileToTapeJob = 3;
            public const int BackupToTapeJob = 4;
            public const int FileCopyJob = 5;
            public const int VMCopyJob = 6;
            
            public CJobType(string s = "")
            {
                _type = Array.IndexOf(Values, s);
            }
            public CJobType(int t = -1)
            {
                _type = t;
            }

            public void Dispose()
            {
                Values = null;
            }

            public override string ToString()
            {
                return Values[_type];
            }

            public static implicit operator int(CJobType x)
            {
                int i = x._type;
                return i;
            }
        }
    }
}
