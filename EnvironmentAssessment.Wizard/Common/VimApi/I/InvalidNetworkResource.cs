namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidNetworkResource : NasConfigFault
	{
		protected string _remoteHost;
		protected string _remotePath;
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
	}
}
