namespace EnvironmentAssessment.Common.VISoap
{
    public class IpPoolIpPoolConfigInfo : DynamicData
	{
		protected string _subnetAddress;
		protected string _netmask;
		protected string _gateway;
		protected string _range;
		protected string[] _dns;
		protected bool? _dhcpServerAvailable;
		protected bool? _ipPoolEnabled;
		public string SubnetAddress
		{
			get
			{
				return this._subnetAddress;
			}
			set
			{
				this._subnetAddress = value;
			}
		}
		public string Netmask
		{
			get
			{
				return this._netmask;
			}
			set
			{
				this._netmask = value;
			}
		}
		public string Gateway
		{
			get
			{
				return this._gateway;
			}
			set
			{
				this._gateway = value;
			}
		}
		public string Range
		{
			get
			{
				return this._range;
			}
			set
			{
				this._range = value;
			}
		}
		public string[] Dns
		{
			get
			{
				return this._dns;
			}
			set
			{
				this._dns = value;
			}
		}
		public bool? DhcpServerAvailable
		{
			get
			{
				return this._dhcpServerAvailable;
			}
			set
			{
				this._dhcpServerAvailable = value;
			}
		}
		public bool? IpPoolEnabled
		{
			get
			{
				return this._ipPoolEnabled;
			}
			set
			{
				this._ipPoolEnabled = value;
			}
		}
	}
}
