namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestOsDescriptor : DynamicData
	{
		protected string _id;
		protected string _family;
		protected string _fullName;
		protected int _supportedMaxCPUs;
		protected int _numSupportedPhysicalSockets;
		protected int _numSupportedCoresPerSocket;
		protected int _supportedMinMemMB;
		protected int _supportedMaxMemMB;
		protected int _recommendedMemMB;
		protected int _recommendedColorDepth;
		protected string[] _supportedDiskControllerList;
		protected string _recommendedSCSIController;
		protected string _recommendedDiskController;
		protected int _supportedNumDisks;
		protected int _recommendedDiskSizeMB;
		protected string _recommendedCdromController;
		protected string[] _supportedEthernetCard;
		protected string _recommendedEthernetCard;
		protected bool? _supportsSlaveDisk;
		protected HostCpuIdInfo[] _cpuFeatureMask;
		protected bool _smcRequired;
		protected bool _supportsWakeOnLan;
		protected bool _supportsVMI;
		protected bool _supportsMemoryHotAdd;
		protected bool _supportsCpuHotAdd;
		protected bool _supportsCpuHotRemove;
		protected string[] _supportedFirmware;
		protected string _recommendedFirmware;
		protected string[] _supportedUSBControllerList;
		protected string _recommendedUSBController;
		protected bool _supports3D;
		protected bool _recommended3D;
		protected bool _smcRecommended;
		protected bool _ich7mRecommended;
		protected bool _usbRecommended;
		protected string _supportLevel;
		protected bool _supportedForCreate;
		protected IntOption _vRAMSizeInKB;
		protected int _numSupportedFloppyDevices;
		protected string[] _wakeOnLanEthernetCard;
		protected bool _supportsPvscsiControllerForBoot;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string Family
		{
			get
			{
				return this._family;
			}
			set
			{
				this._family = value;
			}
		}
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		public int SupportedMaxCPUs
		{
			get
			{
				return this._supportedMaxCPUs;
			}
			set
			{
				this._supportedMaxCPUs = value;
			}
		}
		public int NumSupportedPhysicalSockets
		{
			get
			{
				return this._numSupportedPhysicalSockets;
			}
			set
			{
				this._numSupportedPhysicalSockets = value;
			}
		}
		public int NumSupportedCoresPerSocket
		{
			get
			{
				return this._numSupportedCoresPerSocket;
			}
			set
			{
				this._numSupportedCoresPerSocket = value;
			}
		}
		public int SupportedMinMemMB
		{
			get
			{
				return this._supportedMinMemMB;
			}
			set
			{
				this._supportedMinMemMB = value;
			}
		}
		public int SupportedMaxMemMB
		{
			get
			{
				return this._supportedMaxMemMB;
			}
			set
			{
				this._supportedMaxMemMB = value;
			}
		}
		public int RecommendedMemMB
		{
			get
			{
				return this._recommendedMemMB;
			}
			set
			{
				this._recommendedMemMB = value;
			}
		}
		public int RecommendedColorDepth
		{
			get
			{
				return this._recommendedColorDepth;
			}
			set
			{
				this._recommendedColorDepth = value;
			}
		}
		public string[] SupportedDiskControllerList
		{
			get
			{
				return this._supportedDiskControllerList;
			}
			set
			{
				this._supportedDiskControllerList = value;
			}
		}
		public string RecommendedSCSIController
		{
			get
			{
				return this._recommendedSCSIController;
			}
			set
			{
				this._recommendedSCSIController = value;
			}
		}
		public string RecommendedDiskController
		{
			get
			{
				return this._recommendedDiskController;
			}
			set
			{
				this._recommendedDiskController = value;
			}
		}
		public int SupportedNumDisks
		{
			get
			{
				return this._supportedNumDisks;
			}
			set
			{
				this._supportedNumDisks = value;
			}
		}
		public int RecommendedDiskSizeMB
		{
			get
			{
				return this._recommendedDiskSizeMB;
			}
			set
			{
				this._recommendedDiskSizeMB = value;
			}
		}
		public string RecommendedCdromController
		{
			get
			{
				return this._recommendedCdromController;
			}
			set
			{
				this._recommendedCdromController = value;
			}
		}
		public string[] SupportedEthernetCard
		{
			get
			{
				return this._supportedEthernetCard;
			}
			set
			{
				this._supportedEthernetCard = value;
			}
		}
		public string RecommendedEthernetCard
		{
			get
			{
				return this._recommendedEthernetCard;
			}
			set
			{
				this._recommendedEthernetCard = value;
			}
		}
		public bool? SupportsSlaveDisk
		{
			get
			{
				return this._supportsSlaveDisk;
			}
			set
			{
				this._supportsSlaveDisk = value;
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
		public bool SmcRequired
		{
			get
			{
				return this._smcRequired;
			}
			set
			{
				this._smcRequired = value;
			}
		}
		public bool SupportsWakeOnLan
		{
			get
			{
				return this._supportsWakeOnLan;
			}
			set
			{
				this._supportsWakeOnLan = value;
			}
		}
		public bool SupportsVMI
		{
			get
			{
				return this._supportsVMI;
			}
			set
			{
				this._supportsVMI = value;
			}
		}
		public bool SupportsMemoryHotAdd
		{
			get
			{
				return this._supportsMemoryHotAdd;
			}
			set
			{
				this._supportsMemoryHotAdd = value;
			}
		}
		public bool SupportsCpuHotAdd
		{
			get
			{
				return this._supportsCpuHotAdd;
			}
			set
			{
				this._supportsCpuHotAdd = value;
			}
		}
		public bool SupportsCpuHotRemove
		{
			get
			{
				return this._supportsCpuHotRemove;
			}
			set
			{
				this._supportsCpuHotRemove = value;
			}
		}
		public string[] SupportedFirmware
		{
			get
			{
				return this._supportedFirmware;
			}
			set
			{
				this._supportedFirmware = value;
			}
		}
		public string RecommendedFirmware
		{
			get
			{
				return this._recommendedFirmware;
			}
			set
			{
				this._recommendedFirmware = value;
			}
		}
		public string[] SupportedUSBControllerList
		{
			get
			{
				return this._supportedUSBControllerList;
			}
			set
			{
				this._supportedUSBControllerList = value;
			}
		}
		public string RecommendedUSBController
		{
			get
			{
				return this._recommendedUSBController;
			}
			set
			{
				this._recommendedUSBController = value;
			}
		}
		public bool Supports3D
		{
			get
			{
				return this._supports3D;
			}
			set
			{
				this._supports3D = value;
			}
		}
		public bool Recommended3D
		{
			get
			{
				return this._recommended3D;
			}
			set
			{
				this._recommended3D = value;
			}
		}
		public bool SmcRecommended
		{
			get
			{
				return this._smcRecommended;
			}
			set
			{
				this._smcRecommended = value;
			}
		}
		public bool Ich7mRecommended
		{
			get
			{
				return this._ich7mRecommended;
			}
			set
			{
				this._ich7mRecommended = value;
			}
		}
		public bool UsbRecommended
		{
			get
			{
				return this._usbRecommended;
			}
			set
			{
				this._usbRecommended = value;
			}
		}
		public string SupportLevel
		{
			get
			{
				return this._supportLevel;
			}
			set
			{
				this._supportLevel = value;
			}
		}
		public bool SupportedForCreate
		{
			get
			{
				return this._supportedForCreate;
			}
			set
			{
				this._supportedForCreate = value;
			}
		}
		public IntOption VRAMSizeInKB
		{
			get
			{
				return this._vRAMSizeInKB;
			}
			set
			{
				this._vRAMSizeInKB = value;
			}
		}
		public int NumSupportedFloppyDevices
		{
			get
			{
				return this._numSupportedFloppyDevices;
			}
			set
			{
				this._numSupportedFloppyDevices = value;
			}
		}
		public string[] WakeOnLanEthernetCard
		{
			get
			{
				return this._wakeOnLanEthernetCard;
			}
			set
			{
				this._wakeOnLanEthernetCard = value;
			}
		}
		public bool SupportsPvscsiControllerForBoot
		{
			get
			{
				return this._supportsPvscsiControllerForBoot;
			}
			set
			{
				this._supportsPvscsiControllerForBoot = value;
			}
		}
	}
}
