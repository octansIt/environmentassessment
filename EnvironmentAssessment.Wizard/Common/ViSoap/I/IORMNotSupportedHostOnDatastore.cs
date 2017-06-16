namespace EnvironmentAssessment.Common.VISoap
{
    public class IORMNotSupportedHostOnDatastore : VimFault
	{
		protected ManagedObjectReference _datastore;
		protected string _datastoreName;
		protected ManagedObjectReference[] _host;
		protected IORMNotSupportedHostOnDatastore_LinkedView _linkedView;
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
		public string DatastoreName
		{
			get
			{
				return this._datastoreName;
			}
			set
			{
				this._datastoreName = value;
			}
		}
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public IORMNotSupportedHostOnDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
