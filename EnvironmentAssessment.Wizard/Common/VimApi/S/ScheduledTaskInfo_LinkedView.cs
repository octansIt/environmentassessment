namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskInfo_LinkedView
	{
		protected ScheduledTask _scheduledTask;
		protected ManagedEntity _entity;
		protected Task _activeTask;
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
		public ManagedEntity Entity
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
		public Task ActiveTask
		{
			get
			{
				return this._activeTask;
			}
			set
			{
				this._activeTask = value;
			}
		}
	}
}
