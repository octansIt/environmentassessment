namespace EnvironmentAssessment.Common.VISoap
{
    public class HostApplyProfile : ApplyProfile
	{
		protected HostMemoryProfile _memory;
		protected StorageProfile _storage;
		protected NetworkProfile _network;
		protected DateTimeProfile _datetime;
		protected FirewallProfile _firewall;
		protected SecurityProfile _security;
		protected ServiceProfile[] _service;
		protected OptionProfile[] _option;
		protected UserProfile[] _userAccount;
		protected UserGroupProfile[] _usergroupAccount;
		protected AuthenticationProfile _authentication;
		public HostMemoryProfile Memory
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
		public StorageProfile Storage
		{
			get
			{
				return this._storage;
			}
			set
			{
				this._storage = value;
			}
		}
		public NetworkProfile Network
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
		public DateTimeProfile Datetime
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
		public FirewallProfile Firewall
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
		public SecurityProfile Security
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
		public ServiceProfile[] Service
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
		public OptionProfile[] Option
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
		public UserProfile[] UserAccount
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
		public UserGroupProfile[] UsergroupAccount
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
		public AuthenticationProfile Authentication
		{
			get
			{
				return this._authentication;
			}
			set
			{
				this._authentication = value;
			}
		}
	}
}
