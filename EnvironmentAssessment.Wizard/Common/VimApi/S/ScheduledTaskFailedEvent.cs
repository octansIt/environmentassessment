namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskFailedEvent : ScheduledTaskEvent
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
