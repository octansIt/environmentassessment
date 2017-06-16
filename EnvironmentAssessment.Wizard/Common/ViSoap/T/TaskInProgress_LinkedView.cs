namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskInProgress_LinkedView
	{
		protected Task _task;
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
	}
}
