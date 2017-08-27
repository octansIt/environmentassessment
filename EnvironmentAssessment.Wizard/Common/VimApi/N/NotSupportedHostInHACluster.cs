namespace EnvironmentAssessment.Common.VimApi
{
	public class NotSupportedHostInHACluster : NotSupportedHost
	{
		protected string _hostName;
		protected string _build;
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
		public string Build
		{
			get
			{
				return this._build;
			}
			set
			{
				this._build = value;
			}
		}
	}
}
