namespace EnvironmentAssessment.Common.VimApi
{
	public class AgentInstallFailed : HostConnectFault
	{
		protected string _reason;
		protected int? _statusCode;
		protected string _installerOutput;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public int? StatusCode
		{
			get
			{
				return this._statusCode;
			}
			set
			{
				this._statusCode = value;
			}
		}
		public string InstallerOutput
		{
			get
			{
				return this._installerOutput;
			}
			set
			{
				this._installerOutput = value;
			}
		}
	}
}
