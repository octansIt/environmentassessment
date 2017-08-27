namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetStackInstance : DynamicData
	{
		protected string _key;
		protected string _name;
		protected HostDnsConfig _dnsConfig;
		protected HostIpRouteConfig _ipRouteConfig;
		protected int? _requestedMaxNumberOfConnections;
		protected string _congestionControlAlgorithm;
		protected bool? _ipV6Enabled;
		protected HostIpRouteTableConfig _routeTableConfig;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
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
		public int? RequestedMaxNumberOfConnections
		{
			get
			{
				return this._requestedMaxNumberOfConnections;
			}
			set
			{
				this._requestedMaxNumberOfConnections = value;
			}
		}
		public string CongestionControlAlgorithm
		{
			get
			{
				return this._congestionControlAlgorithm;
			}
			set
			{
				this._congestionControlAlgorithm = value;
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
	}
}
