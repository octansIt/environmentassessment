namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskEvent : Event
	{
		protected ScheduledTaskEventArgument _scheduledTask;
		protected ManagedEntityEventArgument _entity;
		public ScheduledTaskEventArgument ScheduledTask
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
		public ManagedEntityEventArgument Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
	}
}
