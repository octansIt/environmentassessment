namespace EnvironmentAssessment.Common.VimApi
{
	public class KmipServerInfo : DynamicData
	{
		protected string _name;
		protected string _address;
		protected int _port;
		protected string _proxyAddress;
		protected int? _proxyPort;
		protected int? _reconnect;
		protected string _protocol;
		protected int? _nbio;
		protected int? _timeout;
		protected string _userName;
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
		public string Address
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
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public string ProxyAddress
		{
			get
			{
				return this._proxyAddress;
			}
			set
			{
				this._proxyAddress = value;
			}
		}
		public int? ProxyPort
		{
			get
			{
				return this._proxyPort;
			}
			set
			{
				this._proxyPort = value;
			}
		}
		public int? Reconnect
		{
			get
			{
				return this._reconnect;
			}
			set
			{
				this._reconnect = value;
			}
		}
		public string Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
		public int? Nbio
		{
			get
			{
				return this._nbio;
			}
			set
			{
				this._nbio = value;
			}
		}
		public int? Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
	}
}
