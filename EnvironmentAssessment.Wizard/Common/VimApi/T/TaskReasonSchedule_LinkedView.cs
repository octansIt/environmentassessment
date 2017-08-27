namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskReasonSchedule_LinkedView
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
