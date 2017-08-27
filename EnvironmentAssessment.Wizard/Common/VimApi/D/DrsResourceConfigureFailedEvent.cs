namespace EnvironmentAssessment.Common.VimApi
{
	public class DrsResourceConfigureFailedEvent : HostEvent
	{
		protected LocalizedMethodFault _reason;
		public LocalizedMethodFault Reason
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
