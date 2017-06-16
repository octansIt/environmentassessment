namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskFilterSpec_LinkedView
	{
		protected Alarm _alarm;
		protected ScheduledTask _scheduledTask;
		public Alarm Alarm
		{
			get
			{
				return this._alarm;
			}
			set
			{
				this._alarm = value;
			}
		}
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
