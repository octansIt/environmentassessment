using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineRuntimeInfo : DynamicData
	{
		protected VirtualMachineDeviceRuntimeInfo[] _device;
		protected ManagedObjectReference _host;
		protected VirtualMachineConnectionState _connectionState;
		protected VirtualMachinePowerState _powerState;
		protected VirtualMachineFaultToleranceState _faultToleranceState;
		protected VirtualMachineRuntimeInfoDasProtectionState _dasVmProtection;
		protected bool _toolsInstallerMounted;
		protected DateTime? _suspendTime;
		protected DateTime? _bootTime;
		protected long? _suspendInterval;
		protected VirtualMachineQuestionInfo _question;
		protected long? _memoryOverhead;
		protected int? _maxCpuUsage;
		protected int? _maxMemoryUsage;
		protected int _numMksConnections;
		protected VirtualMachineRecordReplayState _recordReplayState;
		protected bool? _cleanPowerOff;
		protected string _needSecondaryReason;
		protected bool _onlineStandby;
		protected string _minRequiredEVCModeKey;
		protected bool _consolidationNeeded;
		protected VirtualMachineFeatureRequirement[] _offlineFeatureRequirement;
		protected VirtualMachineFeatureRequirement[] _featureRequirement;
		protected HostFeatureMask[] _featureMask;
		protected long? _vFlashCacheAllocation;
		protected bool? _paused;
		protected bool? _snapshotInBackground;
		protected bool? _quiescedForkParent;
		protected VirtualMachineRuntimeInfo_LinkedView _linkedView;
		public VirtualMachineDeviceRuntimeInfo[] Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public VirtualMachineConnectionState ConnectionState
		{
			get
			{
				return this._connectionState;
			}
			set
			{
				this._connectionState = value;
			}
		}
		public VirtualMachinePowerState PowerState
		{
			get
			{
				return this._powerState;
			}
			set
			{
				this._powerState = value;
			}
		}
		public VirtualMachineFaultToleranceState FaultToleranceState
		{
			get
			{
				return this._faultToleranceState;
			}
			set
			{
				this._faultToleranceState = value;
			}
		}
		public VirtualMachineRuntimeInfoDasProtectionState DasVmProtection
		{
			get
			{
				return this._dasVmProtection;
			}
			set
			{
				this._dasVmProtection = value;
			}
		}
		public bool ToolsInstallerMounted
		{
			get
			{
				return this._toolsInstallerMounted;
			}
			set
			{
				this._toolsInstallerMounted = value;
			}
		}
		public DateTime? SuspendTime
		{
			get
			{
				return this._suspendTime;
			}
			set
			{
				this._suspendTime = value;
			}
		}
		public DateTime? BootTime
		{
			get
			{
				return this._bootTime;
			}
			set
			{
				this._bootTime = value;
			}
		}
		public long? SuspendInterval
		{
			get
			{
				return this._suspendInterval;
			}
			set
			{
				this._suspendInterval = value;
			}
		}
		public VirtualMachineQuestionInfo Question
		{
			get
			{
				return this._question;
			}
			set
			{
				this._question = value;
			}
		}
		public long? MemoryOverhead
		{
			get
			{
				return this._memoryOverhead;
			}
			set
			{
				this._memoryOverhead = value;
			}
		}
		public int? MaxCpuUsage
		{
			get
			{
				return this._maxCpuUsage;
			}
			set
			{
				this._maxCpuUsage = value;
			}
		}
		public int? MaxMemoryUsage
		{
			get
			{
				return this._maxMemoryUsage;
			}
			set
			{
				this._maxMemoryUsage = value;
			}
		}
		public int NumMksConnections
		{
			get
			{
				return this._numMksConnections;
			}
			set
			{
				this._numMksConnections = value;
			}
		}
		public VirtualMachineRecordReplayState RecordReplayState
		{
			get
			{
				return this._recordReplayState;
			}
			set
			{
				this._recordReplayState = value;
			}
		}
		public bool? CleanPowerOff
		{
			get
			{
				return this._cleanPowerOff;
			}
			set
			{
				this._cleanPowerOff = value;
			}
		}
		public string NeedSecondaryReason
		{
			get
			{
				return this._needSecondaryReason;
			}
			set
			{
				this._needSecondaryReason = value;
			}
		}
		public bool OnlineStandby
		{
			get
			{
				return this._onlineStandby;
			}
			set
			{
				this._onlineStandby = value;
			}
		}
		public string MinRequiredEVCModeKey
		{
			get
			{
				return this._minRequiredEVCModeKey;
			}
			set
			{
				this._minRequiredEVCModeKey = value;
			}
		}
		public bool ConsolidationNeeded
		{
			get
			{
				return this._consolidationNeeded;
			}
			set
			{
				this._consolidationNeeded = value;
			}
		}
		public VirtualMachineFeatureRequirement[] OfflineFeatureRequirement
		{
			get
			{
				return this._offlineFeatureRequirement;
			}
			set
			{
				this._offlineFeatureRequirement = value;
			}
		}
		public VirtualMachineFeatureRequirement[] FeatureRequirement
		{
			get
			{
				return this._featureRequirement;
			}
			set
			{
				this._featureRequirement = value;
			}
		}
		public HostFeatureMask[] FeatureMask
		{
			get
			{
				return this._featureMask;
			}
			set
			{
				this._featureMask = value;
			}
		}
		public long? VFlashCacheAllocation
		{
			get
			{
				return this._vFlashCacheAllocation;
			}
			set
			{
				this._vFlashCacheAllocation = value;
			}
		}
		public bool? Paused
		{
			get
			{
				return this._paused;
			}
			set
			{
				this._paused = value;
			}
		}
		public bool? SnapshotInBackground
		{
			get
			{
				return this._snapshotInBackground;
			}
			set
			{
				this._snapshotInBackground = value;
			}
		}
		public bool? QuiescedForkParent
		{
			get
			{
				return this._quiescedForkParent;
			}
			set
			{
				this._quiescedForkParent = value;
			}
		}
		public VirtualMachineRuntimeInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
