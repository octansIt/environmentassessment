namespace EnvironmentAssessment.Common.VimApi
{
	public class NasSessionCredentialConflict : NasConfigFault
	{
		protected string _remoteHost;
		protected string _remotePath;
		protected string _userName;
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
	}
}
