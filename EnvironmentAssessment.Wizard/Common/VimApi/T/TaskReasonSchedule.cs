namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskReasonSchedule : TaskReason
	{
		protected string _name;
		protected ManagedObjectReference _scheduledTask;
		protected TaskReasonSchedule_LinkedView _linkedView;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
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
		public TaskReasonSchedule_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
