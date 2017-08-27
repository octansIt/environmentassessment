namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestNicInfo : DynamicData
	{
		protected string _network;
		protected string[] _ipAddress;
		protected string _macAddress;
		protected bool _connected;
		protected int _deviceConfigId;
		protected NetDnsConfigInfo _dnsConfig;
		protected NetIpConfigInfo _ipConfig;
		protected NetBIOSConfigInfo _netBIOSConfig;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
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
		public string MacAddress
		{
			get
			{
				return this._macAddress;
			}
			set
			{
				this._macAddress = value;
			}
		}
		public bool Connected
		{
			get
			{
				return this._connected;
			}
			set
			{
				this._connected = value;
			}
		}
		public int DeviceConfigId
		{
			get
			{
				return this._deviceConfigId;
			}
			set
			{
				this._deviceConfigId = value;
			}
		}
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
		public NetIpConfigInfo IpConfig
		{
			get
			{
				return this._ipConfig;
			}
			set
			{
				this._ipConfig = value;
			}
		}
		public NetBIOSConfigInfo NetBIOSConfig
		{
			get
			{
				return this._netBIOSConfig;
			}
			set
			{
				this._netBIOSConfig = value;
			}
		}
	}
}
