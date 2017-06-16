namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskInProgress : VimFault
	{
		protected ManagedObjectReference _task;
		protected TaskInProgress_LinkedView _linkedView;
		public ManagedObjectReference Task
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
		public TaskInProgress_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
