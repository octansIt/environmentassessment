namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreFileEvent : DatastoreEvent
	{
		protected string _targetFile;
		public string TargetFile
		{
			get
			{
				return this._targetFile;
			}
			set
			{
				this._targetFile = value;
			}
		}
	}
}
