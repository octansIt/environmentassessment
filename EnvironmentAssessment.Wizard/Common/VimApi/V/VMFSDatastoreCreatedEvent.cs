namespace EnvironmentAssessment.Common.VimApi
{
	public class VMFSDatastoreCreatedEvent : HostEvent
	{
		protected DatastoreEventArgument _datastore;
		protected string _datastoreUrl;
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
		public string DatastoreUrl
		{
			get
			{
				return this._datastoreUrl;
			}
			set
			{
				this._datastoreUrl = value;
			}
		}
	}
}
