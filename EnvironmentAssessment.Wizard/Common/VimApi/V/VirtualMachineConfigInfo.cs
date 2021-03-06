using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineConfigInfo : DynamicData
	{
		protected string _changeVersion;
		protected DateTime _modified;
		protected string _name;
		protected string _guestFullName;
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
		protected string _locationId;
		protected bool _template;
		protected string _guestId;
		protected string _alternateGuestName;
		protected string _annotation;
		protected VirtualMachineFileInfo _files;
		protected ToolsConfigInfo _tools;
		protected VirtualMachineFlagInfo _flags;
		protected VirtualMachineConsolePreferences _consolePreferences;
		protected VirtualMachineDefaultPowerOpInfo _defaultPowerOps;
		protected VirtualHardware _hardware;
		protected ResourceAllocationInfo _cpuAllocation;
		protected ResourceAllocationInfo _memoryAllocation;
		protected LatencySensitivity _latencySensitivity;
		protected bool? _memoryHotAddEnabled;
		protected bool? _cpuHotAddEnabled;
		protected bool? _cpuHotRemoveEnabled;
		protected long? _hotPlugMemoryLimit;
		protected long? _hotPlugMemoryIncrementSize;
		protected VirtualMachineAffinityInfo _cpuAffinity;
		protected VirtualMachineAffinityInfo _memoryAffinity;
		protected VirtualMachineNetworkShaperInfo _networkShaper;
		protected OptionValue[] _extraConfig;
		protected HostCpuIdInfo[] _cpuFeatureMask;
		protected VirtualMachineConfigInfoDatastoreUrlPair[] _datastoreUrl;
		protected string _swapPlacement;
		protected VirtualMachineBootOptions _bootOptions;
		protected FaultToleranceConfigInfo _ftInfo;
		protected ReplicationConfigSpec _repConfig;
		protected VmConfigInfo _vAppConfig;
		protected bool? _vAssertsEnabled;
		protected bool? _changeTrackingEnabled;
		protected string _firmware;
		protected int? _maxMksConnections;
		protected bool? _guestAutoLockEnabled;
		protected ManagedByInfo _managedBy;
		protected bool? _memoryReservationLockedToMax;
		protected VirtualMachineConfigInfoOverheadInfo _initialOverhead;
		protected bool? _nestedHVEnabled;
		protected bool? _vPMCEnabled;
		protected ScheduledHardwareUpgradeInfo _scheduledHardwareUpgradeInfo;
		protected VirtualMachineForkConfigInfo _forkConfigInfo;
		protected long? _vFlashCacheReservation;
		protected byte[] _vmxConfigChecksum;
		protected bool? _messageBusTunnelEnabled;
		protected string _vmStorageObjectId;
		protected string _swapStorageObjectId;
		protected CryptoKeyId _keyId;
		protected VirtualMachineGuestIntegrityInfo _guestIntegrityInfo;
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
		public DateTime Modified
		{
			get
			{
				return this._modified;
			}
			set
			{
				this._modified = value;
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
		public string GuestFullName
		{
			get
			{
				return this._guestFullName;
			}
			set
			{
				this._guestFullName = value;
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
		public bool Template
		{
			get
			{
				return this._template;
			}
			set
			{
				this._template = value;
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
		public VirtualMachineDefaultPowerOpInfo DefaultPowerOps
		{
			get
			{
				return this._defaultPowerOps;
			}
			set
			{
				this._defaultPowerOps = value;
			}
		}
		public VirtualHardware Hardware
		{
			get
			{
				return this._hardware;
			}
			set
			{
				this._hardware = value;
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
		public long? HotPlugMemoryLimit
		{
			get
			{
				return this._hotPlugMemoryLimit;
			}
			set
			{
				this._hotPlugMemoryLimit = value;
			}
		}
		public long? HotPlugMemoryIncrementSize
		{
			get
			{
				return this._hotPlugMemoryIncrementSize;
			}
			set
			{
				this._hotPlugMemoryIncrementSize = value;
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
		public HostCpuIdInfo[] CpuFeatureMask
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
		public VirtualMachineConfigInfoDatastoreUrlPair[] DatastoreUrl
		{
			get
			{
				return this._datastoreUrl;
			}
			set
			{
				this._datastoreUrl = value;
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
		public VmConfigInfo VAppConfig
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
		public VirtualMachineConfigInfoOverheadInfo InitialOverhead
		{
			get
			{
				return this._initialOverhead;
			}
			set
			{
				this._initialOverhead = value;
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
		public VirtualMachineForkConfigInfo ForkConfigInfo
		{
			get
			{
				return this._forkConfigInfo;
			}
			set
			{
				this._forkConfigInfo = value;
			}
		}
		public long? VFlashCacheReservation
		{
			get
			{
				return this._vFlashCacheReservation;
			}
			set
			{
				this._vFlashCacheReservation = value;
			}
		}
		public byte[] VmxConfigChecksum
		{
			get
			{
				return this._vmxConfigChecksum;
			}
			set
			{
				this._vmxConfigChecksum = value;
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
		public string VmStorageObjectId
		{
			get
			{
				return this._vmStorageObjectId;
			}
			set
			{
				this._vmStorageObjectId = value;
			}
		}
		public string SwapStorageObjectId
		{
			get
			{
				return this._swapStorageObjectId;
			}
			set
			{
				this._swapStorageObjectId = value;
			}
		}
		public CryptoKeyId KeyId
		{
			get
			{
				return this._keyId;
			}
			set
			{
				this._keyId = value;
			}
		}
		public VirtualMachineGuestIntegrityInfo GuestIntegrityInfo
		{
			get
			{
				return this._guestIntegrityInfo;
			}
			set
			{
				this._guestIntegrityInfo = value;
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
