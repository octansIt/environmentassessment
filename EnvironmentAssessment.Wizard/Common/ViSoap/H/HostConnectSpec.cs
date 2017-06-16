namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConnectSpec : DynamicData
	{
		protected string _hostName;
		protected int? _port;
		protected string _sslThumbprint;
		protected string _userName;
		protected string _password;
		protected ManagedObjectReference _vmFolder;
		protected bool _force;
		protected string _vimAccountName;
		protected string _vimAccountPassword;
		protected string _managementIp;
		protected HostConnectSpec_LinkedView _linkedView;
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
		public int? Port
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
		public string SslThumbprint
		{
			get
			{
				return this._sslThumbprint;
			}
			set
			{
				this._sslThumbprint = value;
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
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		public ManagedObjectReference VmFolder
		{
			get
			{
				return this._vmFolder;
			}
			set
			{
				this._vmFolder = value;
			}
		}
		public bool Force
		{
			get
			{
				return this._force;
			}
			set
			{
				this._force = value;
			}
		}
		public string VimAccountName
		{
			get
			{
				return this._vimAccountName;
			}
			set
			{
				this._vimAccountName = value;
			}
		}
		public string VimAccountPassword
		{
			get
			{
				return this._vimAccountPassword;
			}
			set
			{
				this._vimAccountPassword = value;
			}
		}
		public string ManagementIp
		{
			get
			{
				return this._managementIp;
			}
			set
			{
				this._managementIp = value;
			}
		}
		public HostConnectSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
