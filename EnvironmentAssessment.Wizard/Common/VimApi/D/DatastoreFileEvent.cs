namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreFileEvent : DatastoreEvent
	{
		protected string _targetFile;
		protected string _sourceOfOperation;
		protected bool? _succeeded;
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
		public string SourceOfOperation
		{
			get
			{
				return this._sourceOfOperation;
			}
			set
			{
				this._sourceOfOperation = value;
			}
		}
		public bool? Succeeded
		{
			get
			{
				return this._succeeded;
			}
			set
			{
				this._succeeded = value;
			}
		}
	}
}
