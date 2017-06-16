namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNetCapabilities : DynamicData
	{
		protected bool _canSetPhysicalNicLinkSpeed;
		protected bool _supportsNicTeaming;
		protected string[] _nicTeamingPolicy;
		protected bool _supportsVlan;
		protected bool _usesServiceConsoleNic;
		protected bool _supportsNetworkHints;
		protected int? _maxPortGroupsPerVswitch;
		protected bool _vswitchConfigSupported;
		protected bool _vnicConfigSupported;
		protected bool _ipRouteConfigSupported;
		protected bool _dnsConfigSupported;
		protected bool _dhcpOnVnicSupported;
		protected bool _ipV6Supported;
		public bool CanSetPhysicalNicLinkSpeed
		{
			get
			{
				return this._canSetPhysicalNicLinkSpeed;
			}
			set
			{
				this._canSetPhysicalNicLinkSpeed = value;
			}
		}
		public bool SupportsNicTeaming
		{
			get
			{
				return this._supportsNicTeaming;
			}
			set
			{
				this._supportsNicTeaming = value;
			}
		}
		public string[] NicTeamingPolicy
		{
			get
			{
				return this._nicTeamingPolicy;
			}
			set
			{
				this._nicTeamingPolicy = value;
			}
		}
		public bool SupportsVlan
		{
			get
			{
				return this._supportsVlan;
			}
			set
			{
				this._supportsVlan = value;
			}
		}
		public bool UsesServiceConsoleNic
		{
			get
			{
				return this._usesServiceConsoleNic;
			}
			set
			{
				this._usesServiceConsoleNic = value;
			}
		}
		public bool SupportsNetworkHints
		{
			get
			{
				return this._supportsNetworkHints;
			}
			set
			{
				this._supportsNetworkHints = value;
			}
		}
		public int? MaxPortGroupsPerVswitch
		{
			get
			{
				return this._maxPortGroupsPerVswitch;
			}
			set
			{
				this._maxPortGroupsPerVswitch = value;
			}
		}
		public bool VswitchConfigSupported
		{
			get
			{
				return this._vswitchConfigSupported;
			}
			set
			{
				this._vswitchConfigSupported = value;
			}
		}
		public bool VnicConfigSupported
		{
			get
			{
				return this._vnicConfigSupported;
			}
			set
			{
				this._vnicConfigSupported = value;
			}
		}
		public bool IpRouteConfigSupported
		{
			get
			{
				return this._ipRouteConfigSupported;
			}
			set
			{
				this._ipRouteConfigSupported = value;
			}
		}
		public bool DnsConfigSupported
		{
			get
			{
				return this._dnsConfigSupported;
			}
			set
			{
				this._dnsConfigSupported = value;
			}
		}
		public bool DhcpOnVnicSupported
		{
			get
			{
				return this._dhcpOnVnicSupported;
			}
			set
			{
				this._dhcpOnVnicSupported = value;
			}
		}
		public bool IpV6Supported
		{
			get
			{
				return this._ipV6Supported;
			}
			set
			{
				this._ipV6Supported = value;
			}
		}
	}
}
