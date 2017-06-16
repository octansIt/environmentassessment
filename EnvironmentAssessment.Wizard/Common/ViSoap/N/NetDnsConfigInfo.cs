namespace EnvironmentAssessment.Common.VISoap
{
    public class NetDnsConfigInfo : DynamicData
	{
		protected bool _dhcp;
		protected string _hostName;
		protected string _domainName;
		protected string[] _ipAddress;
		protected string[] _searchDomain;
		public bool Dhcp
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
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public string DomainName
		{
			get
			{
				return this._domainName;
			}
			set
			{
				this._domainName = value;
			}
		}
		public string[] IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public string[] SearchDomain
		{
			get
			{
				return this._searchDomain;
			}
			set
			{
				this._searchDomain = value;
			}
		}
	}
}
