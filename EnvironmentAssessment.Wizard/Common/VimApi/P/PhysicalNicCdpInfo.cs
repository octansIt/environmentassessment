namespace EnvironmentAssessment.Common.VimApi
{
	public class PhysicalNicCdpInfo : DynamicData
	{
		protected int? _cdpVersion;
		protected int? _timeout;
		protected int? _ttl;
		protected int? _samples;
		protected string _devId;
		protected string _address;
		protected string _portId;
		protected PhysicalNicCdpDeviceCapability _deviceCapability;
		protected string _softwareVersion;
		protected string _hardwarePlatform;
		protected string _ipPrefix;
		protected int? _ipPrefixLen;
		protected int? _vlan;
		protected bool? _fullDuplex;
		protected int? _mtu;
		protected string _systemName;
		protected string _systemOID;
		protected string _mgmtAddr;
		protected string _location;
		public int? CdpVersion
		{
			get
			{
				return this._cdpVersion;
			}
			set
			{
				this._cdpVersion = value;
			}
		}
		public int? Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
		public int? Ttl
		{
			get
			{
				return this._ttl;
			}
			set
			{
				this._ttl = value;
			}
		}
		public int? Samples
		{
			get
			{
				return this._samples;
			}
			set
			{
				this._samples = value;
			}
		}
		public string DevId
		{
			get
			{
				return this._devId;
			}
			set
			{
				this._devId = value;
			}
		}
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		public string PortId
		{
			get
			{
				return this._portId;
			}
			set
			{
				this._portId = value;
			}
		}
		public PhysicalNicCdpDeviceCapability DeviceCapability
		{
			get
			{
				return this._deviceCapability;
			}
			set
			{
				this._deviceCapability = value;
			}
		}
		public string SoftwareVersion
		{
			get
			{
				return this._softwareVersion;
			}
			set
			{
				this._softwareVersion = value;
			}
		}
		public string HardwarePlatform
		{
			get
			{
				return this._hardwarePlatform;
			}
			set
			{
				this._hardwarePlatform = value;
			}
		}
		public string IpPrefix
		{
			get
			{
				return this._ipPrefix;
			}
			set
			{
				this._ipPrefix = value;
			}
		}
		public int? IpPrefixLen
		{
			get
			{
				return this._ipPrefixLen;
			}
			set
			{
				this._ipPrefixLen = value;
			}
		}
		public int? Vlan
		{
			get
			{
				return this._vlan;
			}
			set
			{
				this._vlan = value;
			}
		}
		public bool? FullDuplex
		{
			get
			{
				return this._fullDuplex;
			}
			set
			{
				this._fullDuplex = value;
			}
		}
		public int? Mtu
		{
			get
			{
				return this._mtu;
			}
			set
			{
				this._mtu = value;
			}
		}
		public string SystemName
		{
			get
			{
				return this._systemName;
			}
			set
			{
				this._systemName = value;
			}
		}
		public string SystemOID
		{
			get
			{
				return this._systemOID;
			}
			set
			{
				this._systemOID = value;
			}
		}
		public string MgmtAddr
		{
			get
			{
				return this._mgmtAddr;
			}
			set
			{
				this._mgmtAddr = value;
			}
		}
		public string Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
	}
}
