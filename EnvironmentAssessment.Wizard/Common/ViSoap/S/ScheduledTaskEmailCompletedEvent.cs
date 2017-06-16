namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskEmailCompletedEvent : ScheduledTaskEvent
	{
		protected string _to;
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
	}
}
