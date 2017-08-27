using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentAssessment.Common.HvApi
{
    public class VirtualDiskType : IDisposable
    {
        private int _type;

        private static string[] _DiskTypes = { "", "", "Thick", "Dynamic", "Differencing" };

        public const int Fixed = 2;
        public const int Dynamic = 3;
        public const int Differencing = 4;

        public VirtualDiskType(string s = "")
        {
            _type = Array.IndexOf(_DiskTypes, s);
        }
        public VirtualDiskType(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            _DiskTypes = null;
        }

        public override string ToString()
        {
            return _DiskTypes[_type];
        }

        public static implicit operator int(VirtualDiskType x)
        {
            int i = x._type;
            return i;
        }
    }

    public class VirtualDiskMode : IDisposable
    {
        private int _type;

        private static string[] _DiskModes = { "", "", "VHD", "VHDX" };

        public const int VHD = 2;
        public const int VHDX = 3;

        public VirtualDiskMode(string s = "")
        {
            _type = Array.IndexOf(_DiskModes, s);
        }
        public VirtualDiskMode(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            _DiskModes = null;
        }

        public override string ToString()
        {
            return _DiskModes[_type];
        }

        public static implicit operator int(VirtualDiskMode x)
        {
            int i = x._type;
            return i;
        }
    }

    class VirtualDisk
    {
        public long Allocated { get; internal set; }
        public int BlockSize { get; internal set; }
        public int Mode { get; internal set; }
        public string ID { get; internal set; }
        public int LogicalSectorSize { get; internal set; }
        public string Name { get; internal set; }
        public string Path { get; internal set; }
        public int PhysicalSectorSize { get; internal set; }
        public int Type { get; internal set; }
        public long Used { get; internal set; }
        public string Datastore { get; internal set; }
    }
}
