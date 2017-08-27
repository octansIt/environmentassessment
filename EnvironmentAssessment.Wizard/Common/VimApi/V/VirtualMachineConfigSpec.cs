namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineConfigSpec : DynamicData
	{
		protected string _changeVersion;
		protected string _name;
		protected string _version;
		protected string _uuid;
		protected string _instanceUuid;
		protected long[] _npivNodeWorldWideName;
		protected long[] _npivPortWorldWideName;
		protected string _npivWorldWideNameType;
		protected short? _npivDesiredNodeWwns;
		protected short? _npivDesiredPortWwns;
		protected bool? _npivTemporaryDisabled;
		protected bool? _npivOnNonRdmDisks;
		protected string _npivWorldWideNameOp;
		protected string _locationId;
		protected string _guestId;
		protected string _alternateGuestName;
		protected string _annotation;
		protected VirtualMachineFileInfo _files;
		protected ToolsConfigInfo _tools;
		protected VirtualMachineFlagInfo _flags;
		protected VirtualMachineConsolePreferences _consolePreferences;
		protected VirtualMachineDefaultPowerOpInfo _powerOpInfo;
		protected int? _numCPUs;
		protected int? _numCoresPerSocket;
		protected long? _memoryMB;
		protected bool? _memoryHotAddEnabled;
		protected bool? _cpuHotAddEnabled;
		protected bool? _cpuHotRemoveEnabled;
		protected bool? _virtualICH7MPresent;
		protected bool? _virtualSMCPresent;
		protected VirtualDeviceConfigSpec[] _deviceChange;
		protected ResourceAllocationInfo _cpuAllocation;
		protected ResourceAllocationInfo _memoryAllocation;
		protected LatencySensitivity _latencySensitivity;
		protected VirtualMachineAffinityInfo _cpuAffinity;
		protected VirtualMachineAffinityInfo _memoryAffinity;
		protected VirtualMachineNetworkShaperInfo _networkShaper;
		protected VirtualMachineCpuIdInfoSpec[] _cpuFeatureMask;
		protected OptionValue[] _extraConfig;
		protected string _swapPlacement;
		protected VirtualMachineBootOptions _bootOptions;
		protected VmConfigSpec _vAppConfig;
		protected FaultToleranceConfigInfo _ftInfo;
		protected ReplicationConfigSpec _repConfig;
		protected bool? _vAppConfigRemoved;
		protected bool? _vAssertsEnabled;
		protected bool? _changeTrackingEnabled;
		protected string _firmware;
		protected int? _maxMksConnections;
		protected bool? _guestAutoLockEnabled;
		protected ManagedByInfo _managedBy;
		protected bool? _memoryReservationLockedToMax;
		protected bool? _nestedHVEnabled;
		protected bool? _vPMCEnabled;
		protected ScheduledHardwareUpgradeInfo _scheduledHardwareUpgradeInfo;
		protected VirtualMachineProfileSpec[] _vmProfile;
		protected bool? _messageBusTunnelEnabled;
		protected CryptoSpec _crypto;
		protected string _migrateEncryption;
		public string ChangeVersion
		{
			get
			{
				return this._changeVersion;
			}
			set
			{
				this._changeVersion = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
		public long[] NpivNodeWorldWideName
		{
			get
			{
				return this._npivNodeWorldWideName;
			}
			set
			{
				this._npivNodeWorldWideName = value;
			}
		}
		public long[] NpivPortWorldWideName
		{
			get
			{
				return this._npivPortWorldWideName;
			}
			set
			{
				this._npivPortWorldWideName = value;
			}
		}
		public string NpivWorldWideNameType
		{
			get
			{
				return this._npivWorldWideNameType;
			}
			set
			{
				this._npivWorldWideNameType = value;
			}
		}
		public short? NpivDesiredNodeWwns
		{
			get
			{
				return this._npivDesiredNodeWwns;
			}
			set
			{
				this._npivDesiredNodeWwns = value;
			}
		}
		public short? NpivDesiredPortWwns
		{
			get
			{
				return this._npivDesiredPortWwns;
			}
			set
			{
				this._npivDesiredPortWwns = value;
			}
		}
		public bool? NpivTemporaryDisabled
		{
			get
			{
				return this._npivTemporaryDisabled;
			}
			set
			{
				this._npivTemporaryDisabled = value;
			}
		}
		public bool? NpivOnNonRdmDisks
		{
			get
			{
				return this._npivOnNonRdmDisks;
			}
			set
			{
				this._npivOnNonRdmDisks = value;
			}
		}
		public string NpivWorldWideNameOp
		{
			get
			{
				return this._npivWorldWideNameOp;
			}
			set
			{
				this._npivWorldWideNameOp = value;
			}
		}
		public string LocationId
		{
			get
			{
				return this._locationId;
			}
			set
			{
				this._locationId = value;
			}
		}
		public string GuestId
		{
			get
			{
				return this._guestId;
			}
			set
			{
				this._guestId = value;
			}
		}
		public string AlternateGuestName
		{
			get
			{
				return this._alternateGuestName;
			}
			set
			{
				this._alternateGuestName = value;
			}
		}
		public string Annotation
		{
			get
			{
				return this._annotation;
			}
			set
			{
				this._annotation = value;
			}
		}
		public VirtualMachineFileInfo Files
		{
			get
			{
				return this._files;
			}
			set
			{
				this._files = value;
			}
		}
		public ToolsConfigInfo Tools
		{
			get
			{
				return this._tools;
			}
			set
			{
				this._tools = value;
			}
		}
		public VirtualMachineFlagInfo Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}
		public VirtualMachineConsolePreferences ConsolePreferences
		{
			get
			{
				return this._consolePreferences;
			}
			set
			{
				this._consolePreferences = value;
			}
		}
		public VirtualMachineDefaultPowerOpInfo PowerOpInfo
		{
			get
			{
				return this._powerOpInfo;
			}
			set
			{
				this._powerOpInfo = value;
			}
		}
		public int? NumCPUs
		{
			get
			{
				return this._numCPUs;
			}
			set
			{
				this._numCPUs = value;
			}
		}
		public int? NumCoresPerSocket
		{
			get
			{
				return this._numCoresPerSocket;
			}
			set
			{
				this._numCoresPerSocket = value;
			}
		}
		public long? MemoryMB
		{
			get
			{
				return this._memoryMB;
			}
			set
			{
				this._memoryMB = value;
			}
		}
		public bool? MemoryHotAddEnabled
		{
			get
			{
				return this._memoryHotAddEnabled;
			}
			set
			{
				this._memoryHotAddEnabled = value;
			}
		}
		public bool? CpuHotAddEnabled
		{
			get
			{
				return this._cpuHotAddEnabled;
			}
			set
			{
				this._cpuHotAddEnabled = value;
			}
		}
		public bool? CpuHotRemoveEnabled
		{
			get
			{
				return this._cpuHotRemoveEnabled;
			}
			set
			{
				this._cpuHotRemoveEnabled = value;
			}
		}
		public bool? VirtualICH7MPresent
		{
			get
			{
				return this._virtualICH7MPresent;
			}
			set
			{
				this._virtualICH7MPresent = value;
			}
		}
		public bool? VirtualSMCPresent
		{
			get
			{
				return this._virtualSMCPresent;
			}
			set
			{
				this._virtualSMCPresent = value;
			}
		}
		public VirtualDeviceConfigSpec[] DeviceChange
		{
			get
			{
				return this._deviceChange;
			}
			set
			{
				this._deviceChange = value;
			}
		}
		public ResourceAllocationInfo CpuAllocation
		{
			get
			{
				return this._cpuAllocation;
			}
			set
			{
				this._cpuAllocation = value;
			}
		}
		public ResourceAllocationInfo MemoryAllocation
		{
			get
			{
				return this._memoryAllocation;
			}
			set
			{
				this._memoryAllocation = value;
			}
		}
		public LatencySensitivity LatencySensitivity
		{
			get
			{
				return this._latencySensitivity;
			}
			set
			{
				this._latencySensitivity = value;
			}
		}
		public VirtualMachineAffinityInfo CpuAffinity
		{
			get
			{
				return this._cpuAffinity;
			}
			set
			{
				this._cpuAffinity = value;
			}
		}
		public VirtualMachineAffinityInfo MemoryAffinity
		{
			get
			{
				return this._memoryAffinity;
			}
			set
			{
				this._memoryAffinity = value;
			}
		}
		public VirtualMachineNetworkShaperInfo NetworkShaper
		{
			get
			{
				return this._networkShaper;
			}
			set
			{
				this._networkShaper = value;
			}
		}
		public VirtualMachineCpuIdInfoSpec[] CpuFeatureMask
		{
			get
			{
				return this._cpuFeatureMask;
			}
			set
			{
				this._cpuFeatureMask = value;
			}
		}
		public OptionValue[] ExtraConfig
		{
			get
			{
				return this._extraConfig;
			}
			set
			{
				this._extraConfig = value;
			}
		}
		public string SwapPlacement
		{
			get
			{
				return this._swapPlacement;
			}
			set
			{
				this._swapPlacement = value;
			}
		}
		public VirtualMachineBootOptions BootOptions
		{
			get
			{
				return this._bootOptions;
			}
			set
			{
				this._bootOptions = value;
			}
		}
		public VmConfigSpec VAppConfig
		{
			get
			{
				return this._vAppConfig;
			}
			set
			{
				this._vAppConfig = value;
			}
		}
		public FaultToleranceConfigInfo FtInfo
		{
			get
			{
				return this._ftInfo;
			}
			set
			{
				this._ftInfo = value;
			}
		}
		public ReplicationConfigSpec RepConfig
		{
			get
			{
				return this._repConfig;
			}
			set
			{
				this._repConfig = value;
			}
		}
		public bool? VAppConfigRemoved
		{
			get
			{
				return this._vAppConfigRemoved;
			}
			set
			{
				this._vAppConfigRemoved = value;
			}
		}
		public bool? VAssertsEnabled
		{
			get
			{
				return this._vAssertsEnabled;
			}
			set
			{
				this._vAssertsEnabled = value;
			}
		}
		public bool? ChangeTrackingEnabled
		{
			get
			{
				return this._changeTrackingEnabled;
			}
			set
			{
				this._changeTrackingEnabled = value;
			}
		}
		public string Firmware
		{
			get
			{
				return this._firmware;
			}
			set
			{
				this._firmware = value;
			}
		}
		public int? MaxMksConnections
		{
			get
			{
				return this._maxMksConnections;
			}
			set
			{
				this._maxMksConnections = value;
			}
		}
		public bool? GuestAutoLockEnabled
		{
			get
			{
				return this._guestAutoLockEnabled;
			}
			set
			{
				this._guestAutoLockEnabled = value;
			}
		}
		public ManagedByInfo ManagedBy
		{
			get
			{
				return this._managedBy;
			}
			set
			{
				this._managedBy = value;
			}
		}
		public bool? MemoryReservationLockedToMax
		{
			get
			{
				return this._memoryReservationLockedToMax;
			}
			set
			{
				this._memoryReservationLockedToMax = value;
			}
		}
		public bool? NestedHVEnabled
		{
			get
			{
				return this._nestedHVEnabled;
			}
			set
			{
				this._nestedHVEnabled = value;
			}
		}
		public bool? VPMCEnabled
		{
			get
			{
				return this._vPMCEnabled;
			}
			set
			{
				this._vPMCEnabled = value;
			}
		}
		public ScheduledHardwareUpgradeInfo ScheduledHardwareUpgradeInfo
		{
			get
			{
				return this._scheduledHardwareUpgradeInfo;
			}
			set
			{
				this._scheduledHardwareUpgradeInfo = value;
			}
		}
		public VirtualMachineProfileSpec[] VmProfile
		{
			get
			{
				return this._vmProfile;
			}
			set
			{
				this._vmProfile = value;
			}
		}
		public bool? MessageBusTunnelEnabled
		{
			get
			{
				return this._messageBusTunnelEnabled;
			}
			set
			{
				this._messageBusTunnelEnabled = value;
			}
		}
		public CryptoSpec Crypto
		{
			get
			{
				return this._crypto;
			}
			set
			{
				this._crypto = value;
			}
		}
		public string MigrateEncryption
		{
			get
			{
				return this._migrateEncryption;
			}
			set
			{
				this._migrateEncryption = value;
			}
		}
	}
}
