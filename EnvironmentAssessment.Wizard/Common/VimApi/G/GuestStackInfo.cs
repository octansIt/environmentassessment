namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestStackInfo : DynamicData
	{
		protected NetDnsConfigInfo _dnsConfig;
		protected NetIpRouteConfigInfo _ipRouteConfig;
		protected KeyValue[] _ipStackConfig;
		protected NetDhcpConfigInfo _dhcpConfig;
		public NetDnsConfigInfo DnsConfig
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
		public NetIpRouteConfigInfo IpRouteConfig
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
		public KeyValue[] IpStackConfig
		{
			get
			{
				return this._ipStackConfig;
			}
			set
			{
				this._ipStackConfig = value;
			}
		}
		public NetDhcpConfigInfo DhcpConfig
		{
			get
			{
				return this._dhcpConfig;
			}
			set
			{
				this._dhcpConfig = value;
			}
		}
	}
}
