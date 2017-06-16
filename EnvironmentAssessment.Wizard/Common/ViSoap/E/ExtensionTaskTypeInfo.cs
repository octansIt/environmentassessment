namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionTaskTypeInfo : DynamicData
	{
		protected string _taskID;
		public string TaskID
		{
			get
			{
				return this._taskID;
			}
			set
			{
				this._taskID = value;
			}
		}
	}
}
