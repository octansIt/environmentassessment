namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskEventArgument_LinkedView
	{
		protected ScheduledTask _scheduledTask;
		public ScheduledTask ScheduledTask
		{
			get
			{
				return this._scheduledTask;
			}
			set
			{
				this._scheduledTask = value;
			}
		}
	}
}
