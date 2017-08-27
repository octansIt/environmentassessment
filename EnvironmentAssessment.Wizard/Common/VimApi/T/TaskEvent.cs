namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskEvent : Event
	{
		protected TaskInfo _info;
		public TaskInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
