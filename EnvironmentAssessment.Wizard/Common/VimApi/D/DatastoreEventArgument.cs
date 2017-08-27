namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _datastore;
		protected DatastoreEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Datastore
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
		public DatastoreEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
