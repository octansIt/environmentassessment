namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaIPProperties : DynamicData
	{
		protected string _mac;
		protected string _address;
		protected bool _dhcpConfigurationEnabled;
		protected string _subnetMask;
		protected string _defaultGateway;
		protected string _primaryDnsServerAddress;
		protected string _alternateDnsServerAddress;
		protected string _ipv6Address;
		protected string _ipv6SubnetMask;
		protected string _ipv6DefaultGateway;
		protected bool? _arpRedirectEnabled;
		protected int? _mtu;
		protected bool? _jumboFramesEnabled;
		protected bool? _ipv4Enabled;
		protected bool? _ipv6Enabled;
		protected HostInternetScsiHbaIPv6Properties _ipv6properties;
		public string Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
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
		public bool DhcpConfigurationEnabled
		{
			get
			{
				return this._dhcpConfigurationEnabled;
			}
			set
			{
				this._dhcpConfigurationEnabled = value;
			}
		}
		public string SubnetMask
		{
			get
			{
				return this._subnetMask;
			}
			set
			{
				this._subnetMask = value;
			}
		}
		public string DefaultGateway
		{
			get
			{
				return this._defaultGateway;
			}
			set
			{
				this._defaultGateway = value;
			}
		}
		public string PrimaryDnsServerAddress
		{
			get
			{
				return this._primaryDnsServerAddress;
			}
			set
			{
				this._primaryDnsServerAddress = value;
			}
		}
		public string AlternateDnsServerAddress
		{
			get
			{
				return this._alternateDnsServerAddress;
			}
			set
			{
				this._alternateDnsServerAddress = value;
			}
		}
		public string Ipv6Address
		{
			get
			{
				return this._ipv6Address;
			}
			set
			{
				this._ipv6Address = value;
			}
		}
		public string Ipv6SubnetMask
		{
			get
			{
				return this._ipv6SubnetMask;
			}
			set
			{
				this._ipv6SubnetMask = value;
			}
		}
		public string Ipv6DefaultGateway
		{
			get
			{
				return this._ipv6DefaultGateway;
			}
			set
			{
				this._ipv6DefaultGateway = value;
			}
		}
		public bool? ArpRedirectEnabled
		{
			get
			{
				return this._arpRedirectEnabled;
			}
			set
			{
				this._arpRedirectEnabled = value;
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
		public bool? JumboFramesEnabled
		{
			get
			{
				return this._jumboFramesEnabled;
			}
			set
			{
				this._jumboFramesEnabled = value;
			}
		}
		public bool? Ipv4Enabled
		{
			get
			{
				return this._ipv4Enabled;
			}
			set
			{
				this._ipv4Enabled = value;
			}
		}
		public bool? Ipv6Enabled
		{
			get
			{
				return this._ipv6Enabled;
			}
			set
			{
				this._ipv6Enabled = value;
			}
		}
		public HostInternetScsiHbaIPv6Properties Ipv6properties
		{
			get
			{
				return this._ipv6properties;
			}
			set
			{
				this._ipv6properties = value;
			}
		}
	}
}
