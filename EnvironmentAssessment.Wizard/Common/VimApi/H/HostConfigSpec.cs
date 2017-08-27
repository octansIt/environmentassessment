namespace EnvironmentAssessment.Common.VimApi
{
	public class HostConfigSpec : DynamicData
	{
		protected HostNasVolumeConfig[] _nasDatastore;
		protected HostNetworkConfig _network;
		protected HostVirtualNicManagerNicTypeSelection[] _nicTypeSelection;
		protected HostServiceConfig[] _service;
		protected HostFirewallConfig _firewall;
		protected OptionValue[] _option;
		protected string _datastorePrincipal;
		protected string _datastorePrincipalPasswd;
		protected HostDateTimeConfig _datetime;
		protected HostStorageDeviceInfo _storageDevice;
		protected HostLicenseSpec _license;
		protected HostSecuritySpec _security;
		protected HostAccountSpec[] _userAccount;
		protected HostAccountSpec[] _usergroupAccount;
		protected HostMemorySpec _memory;
		protected HostActiveDirectory[] _activeDirectory;
		protected KeyAnyValue[] _genericConfig;
		protected HostGraphicsConfig _graphicsConfig;
		public HostNasVolumeConfig[] NasDatastore
		{
			get
			{
				return this._nasDatastore;
			}
			set
			{
				this._nasDatastore = value;
			}
		}
		public HostNetworkConfig Network
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
		public HostVirtualNicManagerNicTypeSelection[] NicTypeSelection
		{
			get
			{
				return this._nicTypeSelection;
			}
			set
			{
				this._nicTypeSelection = value;
			}
		}
		public HostServiceConfig[] Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
			}
		}
		public HostFirewallConfig Firewall
		{
			get
			{
				return this._firewall;
			}
			set
			{
				this._firewall = value;
			}
		}
		public OptionValue[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
		public string DatastorePrincipal
		{
			get
			{
				return this._datastorePrincipal;
			}
			set
			{
				this._datastorePrincipal = value;
			}
		}
		public string DatastorePrincipalPasswd
		{
			get
			{
				return this._datastorePrincipalPasswd;
			}
			set
			{
				this._datastorePrincipalPasswd = value;
			}
		}
		public HostDateTimeConfig Datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				this._datetime = value;
			}
		}
		public HostStorageDeviceInfo StorageDevice
		{
			get
			{
				return this._storageDevice;
			}
			set
			{
				this._storageDevice = value;
			}
		}
		public HostLicenseSpec License
		{
			get
			{
				return this._license;
			}
			set
			{
				this._license = value;
			}
		}
		public HostSecuritySpec Security
		{
			get
			{
				return this._security;
			}
			set
			{
				this._security = value;
			}
		}
		public HostAccountSpec[] UserAccount
		{
			get
			{
				return this._userAccount;
			}
			set
			{
				this._userAccount = value;
			}
		}
		public HostAccountSpec[] UsergroupAccount
		{
			get
			{
				return this._usergroupAccount;
			}
			set
			{
				this._usergroupAccount = value;
			}
		}
		public HostMemorySpec Memory
		{
			get
			{
				return this._memory;
			}
			set
			{
				this._memory = value;
			}
		}
		public HostActiveDirectory[] ActiveDirectory
		{
			get
			{
				return this._activeDirectory;
			}
			set
			{
				this._activeDirectory = value;
			}
		}
		public KeyAnyValue[] GenericConfig
		{
			get
			{
				return this._genericConfig;
			}
			set
			{
				this._genericConfig = value;
			}
		}
		public HostGraphicsConfig GraphicsConfig
		{
			get
			{
				return this._graphicsConfig;
			}
			set
			{
				this._graphicsConfig = value;
			}
		}
	}
}
