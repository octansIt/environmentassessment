namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaIPCapabilities : DynamicData
	{
		protected bool _addressSettable;
		protected bool _ipConfigurationMethodSettable;
		protected bool _subnetMaskSettable;
		protected bool _defaultGatewaySettable;
		protected bool _primaryDnsServerAddressSettable;
		protected bool _alternateDnsServerAddressSettable;
		protected bool? _ipv6Supported;
		protected bool? _arpRedirectSettable;
		protected bool? _mtuSettable;
		protected bool? _hostNameAsTargetAddress;
		protected bool? _nameAliasSettable;
		protected bool? _ipv4EnableSettable;
		protected bool? _ipv6EnableSettable;
		protected bool? _ipv6PrefixLengthSettable;
		protected int? _ipv6PrefixLength;
		protected bool? _ipv6DhcpConfigurationSettable;
		protected bool? _ipv6LinkLocalAutoConfigurationSettable;
		protected bool? _ipv6RouterAdvertisementConfigurationSettable;
		protected bool? _ipv6DefaultGatewaySettable;
		protected int? _ipv6MaxStaticAddressesSupported;
		public bool AddressSettable
		{
			get
			{
				return this._addressSettable;
			}
			set
			{
				this._addressSettable = value;
			}
		}
		public bool IpConfigurationMethodSettable
		{
			get
			{
				return this._ipConfigurationMethodSettable;
			}
			set
			{
				this._ipConfigurationMethodSettable = value;
			}
		}
		public bool SubnetMaskSettable
		{
			get
			{
				return this._subnetMaskSettable;
			}
			set
			{
				this._subnetMaskSettable = value;
			}
		}
		public bool DefaultGatewaySettable
		{
			get
			{
				return this._defaultGatewaySettable;
			}
			set
			{
				this._defaultGatewaySettable = value;
			}
		}
		public bool PrimaryDnsServerAddressSettable
		{
			get
			{
				return this._primaryDnsServerAddressSettable;
			}
			set
			{
				this._primaryDnsServerAddressSettable = value;
			}
		}
		public bool AlternateDnsServerAddressSettable
		{
			get
			{
				return this._alternateDnsServerAddressSettable;
			}
			set
			{
				this._alternateDnsServerAddressSettable = value;
			}
		}
		public bool? Ipv6Supported
		{
			get
			{
				return this._ipv6Supported;
			}
			set
			{
				this._ipv6Supported = value;
			}
		}
		public bool? ArpRedirectSettable
		{
			get
			{
				return this._arpRedirectSettable;
			}
			set
			{
				this._arpRedirectSettable = value;
			}
		}
		public bool? MtuSettable
		{
			get
			{
				return this._mtuSettable;
			}
			set
			{
				this._mtuSettable = value;
			}
		}
		public bool? HostNameAsTargetAddress
		{
			get
			{
				return this._hostNameAsTargetAddress;
			}
			set
			{
				this._hostNameAsTargetAddress = value;
			}
		}
		public bool? NameAliasSettable
		{
			get
			{
				return this._nameAliasSettable;
			}
			set
			{
				this._nameAliasSettable = value;
			}
		}
		public bool? Ipv4EnableSettable
		{
			get
			{
				return this._ipv4EnableSettable;
			}
			set
			{
				this._ipv4EnableSettable = value;
			}
		}
		public bool? Ipv6EnableSettable
		{
			get
			{
				return this._ipv6EnableSettable;
			}
			set
			{
				this._ipv6EnableSettable = value;
			}
		}
		public bool? Ipv6PrefixLengthSettable
		{
			get
			{
				return this._ipv6PrefixLengthSettable;
			}
			set
			{
				this._ipv6PrefixLengthSettable = value;
			}
		}
		public int? Ipv6PrefixLength
		{
			get
			{
				return this._ipv6PrefixLength;
			}
			set
			{
				this._ipv6PrefixLength = value;
			}
		}
		public bool? Ipv6DhcpConfigurationSettable
		{
			get
			{
				return this._ipv6DhcpConfigurationSettable;
			}
			set
			{
				this._ipv6DhcpConfigurationSettable = value;
			}
		}
		public bool? Ipv6LinkLocalAutoConfigurationSettable
		{
			get
			{
				return this._ipv6LinkLocalAutoConfigurationSettable;
			}
			set
			{
				this._ipv6LinkLocalAutoConfigurationSettable = value;
			}
		}
		public bool? Ipv6RouterAdvertisementConfigurationSettable
		{
			get
			{
				return this._ipv6RouterAdvertisementConfigurationSettable;
			}
			set
			{
				this._ipv6RouterAdvertisementConfigurationSettable = value;
			}
		}
		public bool? Ipv6DefaultGatewaySettable
		{
			get
			{
				return this._ipv6DefaultGatewaySettable;
			}
			set
			{
				this._ipv6DefaultGatewaySettable = value;
			}
		}
		public int? Ipv6MaxStaticAddressesSupported
		{
			get
			{
				return this._ipv6MaxStaticAddressesSupported;
			}
			set
			{
				this._ipv6MaxStaticAddressesSupported = value;
			}
		}
	}
}
