namespace EnvironmentAssessment.Common.VISoap
{
    public class UnsupportedDatastore : VmConfigFault
	{
		protected ManagedObjectReference _datastore;
		protected UnsupportedDatastore_LinkedView _linkedView;
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
		public UnsupportedDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
