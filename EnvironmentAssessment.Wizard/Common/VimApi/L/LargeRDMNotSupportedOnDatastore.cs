namespace EnvironmentAssessment.Common.VimApi
{
	public class LargeRDMNotSupportedOnDatastore : VmConfigFault
	{
		protected string _device;
		protected ManagedObjectReference _datastore;
		protected string _datastoreName;
		protected LargeRDMNotSupportedOnDatastore_LinkedView _linkedView;
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
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
		public LargeRDMNotSupportedOnDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
