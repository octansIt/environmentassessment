namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNtpConfig : DynamicData
	{
		protected string[] _server;
		protected string[] _configFile;
		public string[] Server
		{
			get
			{
				return this._server;
			}
			set
			{
				this._server = value;
			}
		}
		public string[] ConfigFile
		{
			get
			{
				return this._configFile;
			}
			set
			{
				this._configFile = value;
			}
		}
	}
}
