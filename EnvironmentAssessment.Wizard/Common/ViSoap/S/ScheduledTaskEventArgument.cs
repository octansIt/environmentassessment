namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _scheduledTask;
		protected ScheduledTaskEventArgument_LinkedView _linkedView;
		public ManagedObjectReference ScheduledTask
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
		public ScheduledTaskEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
