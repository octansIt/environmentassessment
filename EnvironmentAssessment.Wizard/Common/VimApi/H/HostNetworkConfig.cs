namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkConfig : DynamicData
	{
		protected HostVirtualSwitchConfig[] _vswitch;
		protected HostProxySwitchConfig[] _proxySwitch;
		protected HostPortGroupConfig[] _portgroup;
		protected PhysicalNicConfig[] _pnic;
		protected HostVirtualNicConfig[] _vnic;
		protected HostVirtualNicConfig[] _consoleVnic;
		protected HostDnsConfig _dnsConfig;
		protected HostIpRouteConfig _ipRouteConfig;
		protected HostIpRouteConfig _consoleIpRouteConfig;
		protected HostIpRouteTableConfig _routeTableConfig;
		protected HostDhcpServiceConfig[] _dhcp;
		protected HostNatServiceConfig[] _nat;
		protected bool? _ipV6Enabled;
		protected HostNetworkConfigNetStackSpec[] _netStackSpec;
		public HostVirtualSwitchConfig[] Vswitch
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
		public HostProxySwitchConfig[] ProxySwitch
		{
			get
			{
				return this._proxySwitch;
			}
			set
			{
				this._proxySwitch = value;
			}
		}
		public HostPortGroupConfig[] Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public PhysicalNicConfig[] Pnic
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
		public HostVirtualNicConfig[] Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
		public HostVirtualNicConfig[] ConsoleVnic
		{
			get
			{
				return this._consoleVnic;
			}
			set
			{
				this._consoleVnic = value;
			}
		}
		public HostDnsConfig DnsConfig
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
		public HostIpRouteConfig IpRouteConfig
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
		public HostIpRouteConfig ConsoleIpRouteConfig
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
		public HostIpRouteTableConfig RouteTableConfig
		{
			get
			{
				return this._routeTableConfig;
			}
			set
			{
				this._routeTableConfig = value;
			}
		}
		public HostDhcpServiceConfig[] Dhcp
		{
			get
			{
				return this._dhcp;
			}
			set
			{
				this._dhcp = value;
			}
		}
		public HostNatServiceConfig[] Nat
		{
			get
			{
				return this._nat;
			}
			set
			{
				this._nat = value;
			}
		}
		public bool? IpV6Enabled
		{
			get
			{
				return this._ipV6Enabled;
			}
			set
			{
				this._ipV6Enabled = value;
			}
		}
		public HostNetworkConfigNetStackSpec[] NetStackSpec
		{
			get
			{
				return this._netStackSpec;
			}
			set
			{
				this._netStackSpec = value;
			}
		}
	}
}
