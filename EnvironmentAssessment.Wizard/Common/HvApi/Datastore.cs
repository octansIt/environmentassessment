using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common.HvApi
{
    public class DsProvisioningType : IDisposable
    {
        private int _type;

        private static string[] _ProvisioningTypes = { "Unknown", "Thick", "Thin" };

        public const int Unknown = 0;
        public const int Thick = 1;
        public const int Thin = 2;

        public DsProvisioningType(string s = "")
        {
            _type = Array.IndexOf(_ProvisioningTypes, s);
        }
        public DsProvisioningType(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            _ProvisioningTypes = null;
        }

        public override string ToString()
        {
            return _ProvisioningTypes[_type];
        }

        public static implicit operator int(DsProvisioningType x)
        {
            int i = x._type;
            return i;
        }
    }

    public class DsHealthState : IDisposable
    {
        private int _type;

        private static string[] HealthStates = { "Healthy", "Warning", "Unhealthy" };

        public const int Healthy = 0;
        public const int Warning = 1;
        public const int Unhealthy = 2;

        public DsHealthState(string s = "")
        {
            _type = Array.IndexOf(HealthStates, s);
        }
        public DsHealthState(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            HealthStates = null;
        }

        public override string ToString()
        {
            return HealthStates[_type];
        }

        public static implicit operator int(DsHealthState x)
        {
            int i = x._type;
            return i;
        }
    }

    public enum DsBusType
    {
        BusTypeUnknown = 0x00,
        BusTypeSCSI = 0x1,
        BusTypeATAPI = 0x2,
        BusTypeATA = 0x3,
        BusType1394 = 0x4,
        BusTypeSSA = 0x5,
        BusTypeFibre = 0x6,
        BusTypeUSB = 0x7,
        BusTypeRAID = 0x8,
        BusTypeiSCSI = 0x9,
        BusTypeSAS = 0xA,
        BusTypeSATA = 0xB,
        BusTypeSD = 0xC,
        BusTypeMMC = 0xD,
        BusTypeVirtual = 0xE,
        BusTypeFileBackedVirtual = 0xF,
        BusTypeMax = 0x10,
        BusTypeMaxReserved = 0x7F
    }

    internal class Datastore : EntityViewBase
    {

        public long BlockSize { get; internal set; }
        public long Capacity { get; internal set; }
        public long FreeSpace { get; internal set; }
        public string ID { get; internal set; }
        public string FileSystem { get; internal set; }
        public string Name { get; internal set; }
        public string Model { get; internal set; }

        public string Vendor { get; internal set; }
        public string AccessMode { get; internal set; }
        public bool IsBoot { get; internal set; }

        public bool IsClustered { get; internal set; }
        public bool IsHighlyAvailable { get; internal set; }
        public bool IsReadOnly { get; internal set; }
        public bool IsScaleout { get; internal set; }
        public bool IsSystem { get; internal set; }
        public int PhysicalSectorSize { get; internal set; }
        public int LogicalSectorSize { get; internal set; }
        public string ProvisioningType { get; internal set; }
        public string HealthStatus { get; internal set; }
        public string Host { get; internal set; }
        public string Cluster { get; internal set; }
    }
}
