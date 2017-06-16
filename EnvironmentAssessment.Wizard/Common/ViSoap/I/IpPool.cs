namespace EnvironmentAssessment.Common.VISoap
{
    public class IpPool : DynamicData
	{
		protected int? _id;
		protected string _name;
		protected IpPoolIpPoolConfigInfo _ipv4Config;
		protected IpPoolIpPoolConfigInfo _ipv6Config;
		protected string _dnsDomain;
		protected string _dnsSearchPath;
		protected string _hostPrefix;
		protected string _httpProxy;
		protected IpPoolAssociation[] _networkAssociation;
		protected int? _availableIpv4Addresses;
		protected int? _availableIpv6Addresses;
		protected int? _allocatedIpv4Addresses;
		protected int? _allocatedIpv6Addresses;
		public int? Id
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
		public IpPoolIpPoolConfigInfo Ipv4Config
		{
			get
			{
				return this._ipv4Config;
			}
			set
			{
				this._ipv4Config = value;
			}
		}
		public IpPoolIpPoolConfigInfo Ipv6Config
		{
			get
			{
				return this._ipv6Config;
			}
			set
			{
				this._ipv6Config = value;
			}
		}
		public string DnsDomain
		{
			get
			{
				return this._dnsDomain;
			}
			set
			{
				this._dnsDomain = value;
			}
		}
		public string DnsSearchPath
		{
			get
			{
				return this._dnsSearchPath;
			}
			set
			{
				this._dnsSearchPath = value;
			}
		}
		public string HostPrefix
		{
			get
			{
				return this._hostPrefix;
			}
			set
			{
				this._hostPrefix = value;
			}
		}
		public string HttpProxy
		{
			get
			{
				return this._httpProxy;
			}
			set
			{
				this._httpProxy = value;
			}
		}
		public IpPoolAssociation[] NetworkAssociation
		{
			get
			{
				return this._networkAssociation;
			}
			set
			{
				this._networkAssociation = value;
			}
		}
		public int? AvailableIpv4Addresses
		{
			get
			{
				return this._availableIpv4Addresses;
			}
			set
			{
				this._availableIpv4Addresses = value;
			}
		}
		public int? AvailableIpv6Addresses
		{
			get
			{
				return this._availableIpv6Addresses;
			}
			set
			{
				this._availableIpv6Addresses = value;
			}
		}
		public int? AllocatedIpv4Addresses
		{
			get
			{
				return this._allocatedIpv4Addresses;
			}
			set
			{
				this._allocatedIpv4Addresses = value;
			}
		}
		public int? AllocatedIpv6Addresses
		{
			get
			{
				return this._allocatedIpv6Addresses;
			}
			set
			{
				this._allocatedIpv6Addresses = value;
			}
		}
	}
}
