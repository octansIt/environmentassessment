namespace EnvironmentAssessment.Common.VISoap
{
    public class HostHardwareInfo : DynamicData
	{
		protected HostSystemInfo _systemInfo;
		protected HostCpuPowerManagementInfo _cpuPowerManagementInfo;
		protected HostCpuInfo _cpuInfo;
		protected HostCpuPackage[] _cpuPkg;
		protected long _memorySize;
		protected HostNumaInfo _numaInfo;
		protected bool _smcPresent;
		protected HostPciDevice[] _pciDevice;
		protected HostCpuIdInfo[] _cpuFeature;
		protected HostBIOSInfo _biosInfo;
		protected HostReliableMemoryInfo _reliableMemoryInfo;
		public HostSystemInfo SystemInfo
		{
			get
			{
				return this._systemInfo;
			}
			set
			{
				this._systemInfo = value;
			}
		}
		public HostCpuPowerManagementInfo CpuPowerManagementInfo
		{
			get
			{
				return this._cpuPowerManagementInfo;
			}
			set
			{
				this._cpuPowerManagementInfo = value;
			}
		}
		public HostCpuInfo CpuInfo
		{
			get
			{
				return this._cpuInfo;
			}
			set
			{
				this._cpuInfo = value;
			}
		}
		public HostCpuPackage[] CpuPkg
		{
			get
			{
				return this._cpuPkg;
			}
			set
			{
				this._cpuPkg = value;
			}
		}
		public long MemorySize
		{
			get
			{
				return this._memorySize;
			}
			set
			{
				this._memorySize = value;
			}
		}
		public HostNumaInfo NumaInfo
		{
			get
			{
				return this._numaInfo;
			}
			set
			{
				this._numaInfo = value;
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
		public HostPciDevice[] PciDevice
		{
			get
			{
				return this._pciDevice;
			}
			set
			{
				this._pciDevice = value;
			}
		}
		public HostCpuIdInfo[] CpuFeature
		{
			get
			{
				return this._cpuFeature;
			}
			set
			{
				this._cpuFeature = value;
			}
		}
		public HostBIOSInfo BiosInfo
		{
			get
			{
				return this._biosInfo;
			}
			set
			{
				this._biosInfo = value;
			}
		}
		public HostReliableMemoryInfo ReliableMemoryInfo
		{
			get
			{
				return this._reliableMemoryInfo;
			}
			set
			{
				this._reliableMemoryInfo = value;
			}
		}
	}
}
