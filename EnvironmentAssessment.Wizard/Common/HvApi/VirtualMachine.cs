using System;
using System.Collections.Generic;
using System.Net;

namespace EnvironmentAssessment.Common.HvApi
{
    public class VmSettings
    {
        public double Version;

        public string CreationTime { get; internal set; }
    }

    public class VmStorageConfig
    {
        public long Used { get; internal set; }
        public long Allocated { get; internal set; }
    }

    public class VmHardwareConfig
    {
        public long MemoryMB { get; internal set; }
        public int? NumCoresPerSocket { get; internal set; }
        public int NumCPU { get; internal set; }
    }

    public enum VmEnabledState : int
    {
        Unkown = 0,
        Other = 1,
        Enabled = 2,
        Disabled = 3,
        ShuttingDown = 4,
        NotApplicable = 5,
        EnabledButOffline = 6,
        InTest = 7,
        Deferred = 8,
        Quiesce = 9,

        Paused = 32768,
        Suspended = 32769,
        Starting = 32770,
        Snapshotting = 32771,
        Saving = 32773,
        Stopping = 32774,
        Pausing = 32776,
        Resuming = 32777,
    }

    public class VmOperationalState1 : IDisposable
    {
        private int _type;

        private static string[] OperationalStates = { "Creating Snapshot", "Applying Snapshot", "Deleting Snapshot", "Waiting to Start", "Merging Disks", "Exporting Virtual Machine", "Migrating Virtual Machine" };

        public const int CreatingSnapshot = 32768;
        public const int ApplyingSnapshot = 32769;
        public const int DeletingSnapshot = 32770;
        public const int WaitingToStart = 32772;
        public const int ExportingVM = 32773;
        public const int MigratingVM = 32774;

        public VmOperationalState1(string s = "")
        {
            _type = Array.IndexOf(OperationalStates, s) + 32768;
        }
        public VmOperationalState1(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            OperationalStates = null;
        }

        public override string ToString()
        {
            return OperationalStates[_type - 32768];
        }

        public static implicit operator int(VmOperationalState1 x)
        {
            int i = x._type;
            return i;
        }
    }

    public class VmOperationalState0 : IDisposable
    {
        private int _type;

        private static string[] OperationalStates = { "", "OK", "Degraded", "", "", "Predictive Failure", "", "", "", "", "", "Stopped", "In Service", "", "", "", "", "Dormant" };

        public const int OK = 2;
        public const int Degraded = 3;
        public const int PredictiveFailure = 5;
        public const int Stopped = 10;
        public const int InService = 11;
        public const int Dormant = 15;

        public VmOperationalState0(string s = "")
        {
            _type = Array.IndexOf(OperationalStates, s);
        }
        public VmOperationalState0(int t = -1)
        {
            _type = t;
        }

        public void Dispose()
        {
            OperationalStates = null;
        }

        public override string ToString()
        {
            return OperationalStates[_type];
        }

        public static implicit operator int(VmOperationalState0 x)
        {
            int i = x._type;
            return i;
        }
    }

    internal class VirtualMachine : EntityViewBase
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public int State { get; internal set; }
        public string Host { get; internal set; }
        public string Cluster { get; internal set; }

        public GuestConfig Guest = new GuestConfig();
        public class GuestConfig
        {
            public IPAddress IP { get; internal set; }
            public string Name { get; internal set; }
            public string OS { get; internal set; }
            public string ToolsVersion { get; internal set; }
        }

        public VmStorageConfig Storage = new VmStorageConfig();

        public string Version = "";
        public VmHardwareConfig Hardware = new VmHardwareConfig();

        public List<VirtualDisk> Disks = new List<VirtualDisk> { };
    }
}