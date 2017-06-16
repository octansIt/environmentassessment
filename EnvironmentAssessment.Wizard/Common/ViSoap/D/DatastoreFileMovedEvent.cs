namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreFileMovedEvent : DatastoreFileEvent
	{
		protected DatastoreEventArgument _sourceDatastore;
		protected string _sourceFile;
		public DatastoreEventArgument SourceDatastore
		{
			get
			{
				return this._sourceDatastore;
			}
			set
			{
				this._sourceDatastore = value;
			}
		}
		public string SourceFile
		{
			get
			{
				return this._sourceFile;
			}
			set
			{
				this._sourceFile = value;
			}
		}
	}
}
