namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreRemovedOnHostEvent : HostEvent
	{
		protected DatastoreEventArgument _datastore;
		public DatastoreEventArgument Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
	}
}
