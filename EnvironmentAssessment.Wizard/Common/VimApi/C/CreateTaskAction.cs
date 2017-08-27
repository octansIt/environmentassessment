namespace EnvironmentAssessment.Common.VimApi
{
	public class CreateTaskAction : Action
	{
		protected string _taskTypeId;
		protected bool _cancelable;
		public string TaskTypeId
		{
			get
			{
				return this._taskTypeId;
			}
			set
			{
				this._taskTypeId = value;
			}
		}
		public bool Cancelable
		{
			get
			{
				return this._cancelable;
			}
			set
			{
				this._cancelable = value;
			}
		}
	}
}
