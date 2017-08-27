namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileManagerConfigTaskList : DynamicData
	{
		protected HostConfigSpec _configSpec;
		protected LocalizableMessage[] _taskDescription;
		protected string[] _taskListRequirement;
		public HostConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public LocalizableMessage[] TaskDescription
		{
			get
			{
				return this._taskDescription;
			}
			set
			{
				this._taskDescription = value;
			}
		}
		public string[] TaskListRequirement
		{
			get
			{
				return this._taskListRequirement;
			}
			set
			{
				this._taskListRequirement = value;
			}
		}
	}
}
