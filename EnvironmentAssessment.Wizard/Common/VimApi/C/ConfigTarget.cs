namespace EnvironmentAssessment.Common.VimApi
{
	public class ConfigTarget : DynamicData
	{
		protected int _numCpus;
		protected int _numCpuCores;
		protected int _numNumaNodes;
		protected bool _smcPresent;
		protected VirtualMachineDatastoreInfo[] _datastore;
		protected VirtualMachineNetworkInfo[] _network;
		protected OpaqueNetworkTargetInfo[] _opaqueNetwork;
		protected DistributedVirtualPortgroupInfo[] _distributedVirtualPortgroup;
		protected DistributedVirtualSwitchInfo[] _distributedVirtualSwitch;
		protected VirtualMachineCdromInfo[] _cdRom;
		protected VirtualMachineSerialInfo[] _serial;
		protected VirtualMachineParallelInfo[] _parallel;
		protected VirtualMachineSoundInfo[] _sound;
		protected VirtualMachineUsbInfo[] _usb;
		protected VirtualMachineFloppyInfo[] _floppy;
		protected VirtualMachineLegacyNetworkSwitchInfo[] _legacyNetworkInfo;
		protected VirtualMachineScsiPassthroughInfo[] _scsiPassthrough;
		protected VirtualMachineScsiDiskDeviceInfo[] _scsiDisk;
		protected VirtualMachineIdeDiskDeviceInfo[] _ideDisk;
		protected int _maxMemMBOptimalPerf;
		protected ResourcePoolRuntimeInfo _resourcePool;
		protected bool? _autoVmotion;
		protected VirtualMachinePciPassthroughInfo[] _pciPassthrough;
		protected VirtualMachineSriovInfo[] _sriov;
		protected VirtualMachineVFlashModuleInfo[] _vFlashModule;
		protected VirtualMachinePciSharedGpuPassthroughInfo[] _sharedGpuPassthroughTypes;
		public int NumCpus
		{
			get
			{
				return this._numCpus;
			}
			set
			{
				this._numCpus = value;
			}
		}
		public int NumCpuCores
		{
			get
			{
				return this._numCpuCores;
			}
			set
			{
				this._numCpuCores = value;
			}
		}
		public int NumNumaNodes
		{
			get
			{
				return this._numNumaNodes;
			}
			set
			{
				this._numNumaNodes = value;
			}
		}
		public bool SmcPresent
		{
			get
			{
				return this._smcPresent;
			}
			set
			{
				this._smcPresent = value;
			}
		}
		public VirtualMachineDatastoreInfo[] Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public VirtualMachineNetworkInfo[] Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public OpaqueNetworkTargetInfo[] OpaqueNetwork
		{
			get
			{
				return this._opaqueNetwork;
			}
			set
			{
				this._opaqueNetwork = value;
			}
		}
		public DistributedVirtualPortgroupInfo[] DistributedVirtualPortgroup
		{
			get
			{
				return this._distributedVirtualPortgroup;
			}
			set
			{
				this._distributedVirtualPortgroup = value;
			}
		}
		public DistributedVirtualSwitchInfo[] DistributedVirtualSwitch
		{
			get
			{
				return this._distributedVirtualSwitch;
			}
			set
			{
				this._distributedVirtualSwitch = value;
			}
		}
		public VirtualMachineCdromInfo[] CdRom
		{
			get
			{
				return this._cdRom;
			}
			set
			{
				this._cdRom = value;
			}
		}
		public VirtualMachineSerialInfo[] Serial
		{
			get
			{
				return this._serial;
			}
			set
			{
				this._serial = value;
			}
		}
		public VirtualMachineParallelInfo[] Parallel
		{
			get
			{
				return this._parallel;
			}
			set
			{
				this._parallel = value;
			}
		}
		public VirtualMachineSoundInfo[] Sound
		{
			get
			{
				return this._sound;
			}
			set
			{
				this._sound = value;
			}
		}
		public VirtualMachineUsbInfo[] Usb
		{
			get
			{
				return this._usb;
			}
			set
			{
				this._usb = value;
			}
		}
		public VirtualMachineFloppyInfo[] Floppy
		{
			get
			{
				return this._floppy;
			}
			set
			{
				this._floppy = value;
			}
		}
		public VirtualMachineLegacyNetworkSwitchInfo[] LegacyNetworkInfo
		{
			get
			{
				return this._legacyNetworkInfo;
			}
			set
			{
				this._legacyNetworkInfo = value;
			}
		}
		public VirtualMachineScsiPassthroughInfo[] ScsiPassthrough
		{
			get
			{
				return this._scsiPassthrough;
			}
			set
			{
				this._scsiPassthrough = value;
			}
		}
		public VirtualMachineScsiDiskDeviceInfo[] ScsiDisk
		{
			get
			{
				return this._scsiDisk;
			}
			set
			{
				this._scsiDisk = value;
			}
		}
		public VirtualMachineIdeDiskDeviceInfo[] IdeDisk
		{
			get
			{
				return this._ideDisk;
			}
			set
			{
				this._ideDisk = value;
			}
		}
		public int MaxMemMBOptimalPerf
		{
			get
			{
				return this._maxMemMBOptimalPerf;
			}
			set
			{
				this._maxMemMBOptimalPerf = value;
			}
		}
		public ResourcePoolRuntimeInfo ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
			set
			{
				this._resourcePool = value;
			}
		}
		public bool? AutoVmotion
		{
			get
			{
				return this._autoVmotion;
			}
			set
			{
				this._autoVmotion = value;
			}
		}
		public VirtualMachinePciPassthroughInfo[] PciPassthrough
		{
			get
			{
				return this._pciPassthrough;
			}
			set
			{
				this._pciPassthrough = value;
			}
		}
		public VirtualMachineSriovInfo[] Sriov
		{
			get
			{
				return this._sriov;
			}
			set
			{
				this._sriov = value;
			}
		}
		public VirtualMachineVFlashModuleInfo[] VFlashModule
		{
			get
			{
				return this._vFlashModule;
			}
			set
			{
				this._vFlashModule = value;
			}
		}
		public VirtualMachinePciSharedGpuPassthroughInfo[] SharedGpuPassthroughTypes
		{
			get
			{
				return this._sharedGpuPassthroughTypes;
			}
			set
			{
				this._sharedGpuPassthroughTypes = value;
			}
		}
	}
}
