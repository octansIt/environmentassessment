namespace EnvironmentAssessment.Common.VimApi
{
	public class VcAgentUninstallFailedEvent : HostEvent
	{
		protected string _reason;
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
