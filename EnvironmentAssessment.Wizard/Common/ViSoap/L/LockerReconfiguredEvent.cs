namespace EnvironmentAssessment.Common.VISoap
{
    public class LockerReconfiguredEvent : Event
	{
		protected DatastoreEventArgument _oldDatastore;
		protected DatastoreEventArgument _newDatastore;
		public DatastoreEventArgument OldDatastore
		{
			get
			{
				return this._oldDatastore;
			}
			set
			{
				this._oldDatastore = value;
			}
		}
		public DatastoreEventArgument NewDatastore
		{
			get
			{
				return this._newDatastore;
			}
			set
			{
				this._newDatastore = value;
			}
		}
	}
}
