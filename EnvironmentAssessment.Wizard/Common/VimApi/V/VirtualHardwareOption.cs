namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualHardwareOption : DynamicData
	{
		protected int _hwVersion;
		protected VirtualDeviceOption[] _virtualDeviceOption;
		protected bool _deviceListReadonly;
		protected int[] _numCPU;
		protected IntOption _numCoresPerSocket;
		protected bool _numCpuReadonly;
		protected LongOption _memoryMB;
		protected IntOption _numPCIControllers;
		protected IntOption _numIDEControllers;
		protected IntOption _numUSBControllers;
		protected IntOption _numUSBXHCIControllers;
		protected IntOption _numSIOControllers;
		protected IntOption _numPS2Controllers;
		protected string[] _licensingLimit;
		protected IntOption _numSupportedWwnPorts;
		protected IntOption _numSupportedWwnNodes;
		protected ResourceConfigOption _resourceConfigOption;
		public int HwVersion
		{
			get
			{
				return this._hwVersion;
			}
			set
			{
				this._hwVersion = value;
			}
		}
		public VirtualDeviceOption[] VirtualDeviceOption
		{
			get
			{
				return this._virtualDeviceOption;
			}
			set
			{
				this._virtualDeviceOption = value;
			}
		}
		public bool DeviceListReadonly
		{
			get
			{
				return this._deviceListReadonly;
			}
			set
			{
				this._deviceListReadonly = value;
			}
		}
		public int[] NumCPU
		{
			get
			{
				return this._numCPU;
			}
			set
			{
				this._numCPU = value;
			}
		}
		public IntOption NumCoresPerSocket
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
		public bool NumCpuReadonly
		{
			get
			{
				return this._numCpuReadonly;
			}
			set
			{
				this._numCpuReadonly = value;
			}
		}
		public LongOption MemoryMB
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
		public IntOption NumPCIControllers
		{
			get
			{
				return this._numPCIControllers;
			}
			set
			{
				this._numPCIControllers = value;
			}
		}
		public IntOption NumIDEControllers
		{
			get
			{
				return this._numIDEControllers;
			}
			set
			{
				this._numIDEControllers = value;
			}
		}
		public IntOption NumUSBControllers
		{
			get
			{
				return this._numUSBControllers;
			}
			set
			{
				this._numUSBControllers = value;
			}
		}
		public IntOption NumUSBXHCIControllers
		{
			get
			{
				return this._numUSBXHCIControllers;
			}
			set
			{
				this._numUSBXHCIControllers = value;
			}
		}
		public IntOption NumSIOControllers
		{
			get
			{
				return this._numSIOControllers;
			}
			set
			{
				this._numSIOControllers = value;
			}
		}
		public IntOption NumPS2Controllers
		{
			get
			{
				return this._numPS2Controllers;
			}
			set
			{
				this._numPS2Controllers = value;
			}
		}
		public string[] LicensingLimit
		{
			get
			{
				return this._licensingLimit;
			}
			set
			{
				this._licensingLimit = value;
			}
		}
		public IntOption NumSupportedWwnPorts
		{
			get
			{
				return this._numSupportedWwnPorts;
			}
			set
			{
				this._numSupportedWwnPorts = value;
			}
		}
		public IntOption NumSupportedWwnNodes
		{
			get
			{
				return this._numSupportedWwnNodes;
			}
			set
			{
				this._numSupportedWwnNodes = value;
			}
		}
		public ResourceConfigOption ResourceConfigOption
		{
			get
			{
				return this._resourceConfigOption;
			}
			set
			{
				this._resourceConfigOption = value;
			}
		}
	}
}
