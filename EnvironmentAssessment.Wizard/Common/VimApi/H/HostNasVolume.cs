namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNasVolume : HostFileSystemVolume
	{
		protected string _remoteHost;
		protected string _remotePath;
		protected string _userName;
		protected string[] _remoteHostNames;
		protected string _securityType;
		protected bool? _protocolEndpoint;
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
		public bool? ProtocolEndpoint
		{
			get
			{
				return this._protocolEndpoint;
			}
			set
			{
				this._protocolEndpoint = value;
			}
		}
	}
}
