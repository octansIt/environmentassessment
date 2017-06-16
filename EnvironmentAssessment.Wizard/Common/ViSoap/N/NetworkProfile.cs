namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworkProfile : ApplyProfile
	{
		protected VirtualSwitchProfile[] _vswitch;
		protected VmPortGroupProfile[] _vmPortGroup;
		protected HostPortGroupProfile[] _hostPortGroup;
		protected ServiceConsolePortGroupProfile[] _serviceConsolePortGroup;
		protected NetworkProfileDnsConfigProfile _dnsConfig;
		protected IpRouteProfile _ipRouteConfig;
		protected IpRouteProfile _consoleIpRouteConfig;
		protected PhysicalNicProfile[] _pnic;
		protected DvsProfile[] _dvswitch;
		protected DvsServiceConsoleVNicProfile[] _dvsServiceConsoleNic;
		protected DvsHostVNicProfile[] _dvsHostNic;
		protected NetStackInstanceProfile[] _netStackInstance;
		public VirtualSwitchProfile[] Vswitch
		{
			get
			{
				return this._vswitch;
			}
			set
			{
				this._vswitch = value;
			}
		}
		public VmPortGroupProfile[] VmPortGroup
		{
			get
			{
				return this._vmPortGroup;
			}
			set
			{
				this._vmPortGroup = value;
			}
		}
		public HostPortGroupProfile[] HostPortGroup
		{
			get
			{
				return this._hostPortGroup;
			}
			set
			{
				this._hostPortGroup = value;
			}
		}
		public ServiceConsolePortGroupProfile[] ServiceConsolePortGroup
		{
			get
			{
				return this._serviceConsolePortGroup;
			}
			set
			{
				this._serviceConsolePortGroup = value;
			}
		}
		public NetworkProfileDnsConfigProfile DnsConfig
		{
			get
			{
				return this._dnsConfig;
			}
			set
			{
				this._dnsConfig = value;
			}
		}
		public IpRouteProfile IpRouteConfig
		{
			get
			{
				return this._ipRouteConfig;
			}
			set
			{
				this._ipRouteConfig = value;
			}
		}
		public IpRouteProfile ConsoleIpRouteConfig
		{
			get
			{
				return this._consoleIpRouteConfig;
			}
			set
			{
				this._consoleIpRouteConfig = value;
			}
		}
		public PhysicalNicProfile[] Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
		public DvsProfile[] Dvswitch
		{
			get
			{
				return this._dvswitch;
			}
			set
			{
				this._dvswitch = value;
			}
		}
		public DvsServiceConsoleVNicProfile[] DvsServiceConsoleNic
		{
			get
			{
				return this._dvsServiceConsoleNic;
			}
			set
			{
				this._dvsServiceConsoleNic = value;
			}
		}
		public DvsHostVNicProfile[] DvsHostNic
		{
			get
			{
				return this._dvsHostNic;
			}
			set
			{
				this._dvsHostNic = value;
			}
		}
		public NetStackInstanceProfile[] NetStackInstance
		{
			get
			{
				return this._netStackInstance;
			}
			set
			{
				this._netStackInstance = value;
			}
		}
	}
}
