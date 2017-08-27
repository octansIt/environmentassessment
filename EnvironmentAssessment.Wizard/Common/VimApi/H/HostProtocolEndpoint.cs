namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProtocolEndpoint : DynamicData
	{
		protected string _peType;
		protected string _type;
		protected string _uuid;
		protected ManagedObjectReference[] _hostKey;
		protected string _storageArray;
		protected string _nfsServer;
		protected string _nfsDir;
		protected string _nfsServerScope;
		protected string _nfsServerMajor;
		protected string _nfsServerAuthType;
		protected string _nfsServerUser;
		protected string _deviceId;
		protected HostProtocolEndpoint_LinkedView _linkedView;
		public string PeType
		{
			get
			{
				return this._peType;
			}
			set
			{
				this._peType = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public ManagedObjectReference[] HostKey
		{
			get
			{
				return this._hostKey;
			}
			set
			{
				this._hostKey = value;
			}
		}
		public string StorageArray
		{
			get
			{
				return this._storageArray;
			}
			set
			{
				this._storageArray = value;
			}
		}
		public string NfsServer
		{
			get
			{
				return this._nfsServer;
			}
			set
			{
				this._nfsServer = value;
			}
		}
		public string NfsDir
		{
			get
			{
				return this._nfsDir;
			}
			set
			{
				this._nfsDir = value;
			}
		}
		public string NfsServerScope
		{
			get
			{
				return this._nfsServerScope;
			}
			set
			{
				this._nfsServerScope = value;
			}
		}
		public string NfsServerMajor
		{
			get
			{
				return this._nfsServerMajor;
			}
			set
			{
				this._nfsServerMajor = value;
			}
		}
		public string NfsServerAuthType
		{
			get
			{
				return this._nfsServerAuthType;
			}
			set
			{
				this._nfsServerAuthType = value;
			}
		}
		public string NfsServerUser
		{
			get
			{
				return this._nfsServerUser;
			}
			set
			{
				this._nfsServerUser = value;
			}
		}
		public string DeviceId
		{
			get
			{
				return this._deviceId;
			}
			set
			{
				this._deviceId = value;
			}
		}
		public HostProtocolEndpoint_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
