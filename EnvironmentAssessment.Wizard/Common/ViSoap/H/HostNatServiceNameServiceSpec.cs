namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNatServiceNameServiceSpec : DynamicData
	{
		protected bool _dnsAutoDetect;
		protected string _dnsPolicy;
		protected int _dnsRetries;
		protected int _dnsTimeout;
		protected string[] _dnsNameServer;
		protected int _nbdsTimeout;
		protected int _nbnsRetries;
		protected int _nbnsTimeout;
		public bool DnsAutoDetect
		{
			get
			{
				return this._dnsAutoDetect;
			}
			set
			{
				this._dnsAutoDetect = value;
			}
		}
		public string DnsPolicy
		{
			get
			{
				return this._dnsPolicy;
			}
			set
			{
				this._dnsPolicy = value;
			}
		}
		public int DnsRetries
		{
			get
			{
				return this._dnsRetries;
			}
			set
			{
				this._dnsRetries = value;
			}
		}
		public int DnsTimeout
		{
			get
			{
				return this._dnsTimeout;
			}
			set
			{
				this._dnsTimeout = value;
			}
		}
		public string[] DnsNameServer
		{
			get
			{
				return this._dnsNameServer;
			}
			set
			{
				this._dnsNameServer = value;
			}
		}
		public int NbdsTimeout
		{
			get
			{
				return this._nbdsTimeout;
			}
			set
			{
				this._nbdsTimeout = value;
			}
		}
		public int NbnsRetries
		{
			get
			{
				return this._nbnsRetries;
			}
			set
			{
				this._nbnsRetries = value;
			}
		}
		public int NbnsTimeout
		{
			get
			{
				return this._nbnsTimeout;
			}
			set
			{
				this._nbnsTimeout = value;
			}
		}
	}
}
