namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNetworkInfo : DynamicData
	{
		protected HostVirtualSwitch[] _vswitch;
		protected HostProxySwitch[] _proxySwitch;
		protected HostPortGroup[] _portgroup;
		protected PhysicalNic[] _pnic;
		protected HostVirtualNic[] _vnic;
		protected HostVirtualNic[] _consoleVnic;
		protected HostDnsConfig _dnsConfig;
		protected HostIpRouteConfig _ipRouteConfig;
		protected HostIpRouteConfig _consoleIpRouteConfig;
		protected HostIpRouteTableInfo _routeTableInfo;
		protected HostDhcpService[] _dhcp;
		protected HostNatService[] _nat;
		protected bool? _ipV6Enabled;
		protected bool? _atBootIpV6Enabled;
		protected HostNetStackInstance[] _netStackInstance;
		protected HostOpaqueSwitch[] _opaqueSwitch;
		protected HostOpaqueNetworkInfo[] _opaqueNetwork;
		public HostVirtualSwitch[] Vswitch
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
		public HostProxySwitch[] ProxySwitch
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
		public HostPortGroup[] Portgroup
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
		public PhysicalNic[] Pnic
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
		public HostVirtualNic[] Vnic
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
		public HostVirtualNic[] ConsoleVnic
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
		public HostIpRouteTableInfo RouteTableInfo
		{
			get
			{
				return this._routeTableInfo;
			}
			set
			{
				this._routeTableInfo = value;
			}
		}
		public HostDhcpService[] Dhcp
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
		public HostNatService[] Nat
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
		public bool? AtBootIpV6Enabled
		{
			get
			{
				return this._atBootIpV6Enabled;
			}
			set
			{
				this._atBootIpV6Enabled = value;
			}
		}
		public HostNetStackInstance[] NetStackInstance
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
		public HostOpaqueSwitch[] OpaqueSwitch
		{
			get
			{
				return this._opaqueSwitch;
			}
			set
			{
				this._opaqueSwitch = value;
			}
		}
		public HostOpaqueNetworkInfo[] OpaqueNetwork
		{
			get
			{
				return this._opaqueNetwork;
			}
			set
			{
				this._opaqueNetwork = value;
			}
		}
	}
}
