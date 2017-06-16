namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskEmailFailedEvent : ScheduledTaskEvent
	{
		protected string _to;
		protected LocalizedMethodFault _reason;
		public string To
		{
			get
			{
				return this._to;
			}
			set
			{
				this._to = value;
			}
		}
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
