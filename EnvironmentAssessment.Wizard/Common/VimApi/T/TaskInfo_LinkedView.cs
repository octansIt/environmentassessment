namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskInfo_LinkedView
	{
		protected Task _task;
		protected ManagedEntity _entity;
		protected ManagedEntity[] _locked;
		public Task Task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task = value;
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
		public ManagedEntity[] Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				this._locked = value;
			}
		}
	}
}
