namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIncompatibleForRecordReplay : VimFault
	{
		protected string _hostName;
		protected string _reason;
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
	}
}
