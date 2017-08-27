namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDnsConfig : DynamicData
	{
		protected bool _dhcp;
		protected string _virtualNicDevice;
		protected string _hostName;
		protected string _domainName;
		protected string[] _address;
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
		public string VirtualNicDevice
		{
			get
			{
				return this._virtualNicDevice;
			}
			set
			{
				this._virtualNicDevice = value;
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
		public string[] Address
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
