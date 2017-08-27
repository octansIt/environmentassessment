namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNasVolumeSpec : DynamicData
	{
		protected string _remoteHost;
		protected string _remotePath;
		protected string _localPath;
		protected string _accessMode;
		protected string _type;
		protected string _userName;
		protected string _password;
		protected string[] _remoteHostNames;
		protected string _securityType;
		public string RemoteHost
		{
			get
			{
				return this._remoteHost;
			}
			set
			{
				this._remoteHost = value;
			}
		}
		public string RemotePath
		{
			get
			{
				return this._remotePath;
			}
			set
			{
				this._remotePath = value;
			}
		}
		public string LocalPath
		{
			get
			{
				return this._localPath;
			}
			set
			{
				this._localPath = value;
			}
		}
		public string AccessMode
		{
			get
			{
				return this._accessMode;
			}
			set
			{
				this._accessMode = value;
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
		public string[] RemoteHostNames
		{
			get
			{
				return this._remoteHostNames;
			}
			set
			{
				this._remoteHostNames = value;
			}
		}
		public string SecurityType
		{
			get
			{
				return this._securityType;
			}
			set
			{
				this._securityType = value;
			}
		}
	}
}
