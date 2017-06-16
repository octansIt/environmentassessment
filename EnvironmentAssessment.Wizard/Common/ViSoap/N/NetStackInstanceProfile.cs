namespace EnvironmentAssessment.Common.VISoap
{
    public class NetStackInstanceProfile : ApplyProfile
	{
		protected string _key;
		protected NetworkProfileDnsConfigProfile _dnsConfig;
		protected IpRouteProfile _ipRouteConfig;
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
	}
}
