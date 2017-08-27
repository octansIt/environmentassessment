namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageRequirement : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected long _freeSpaceRequiredInKb;
		protected StorageRequirement_LinkedView _linkedView;
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
		public long FreeSpaceRequiredInKb
		{
			get
			{
				return this._freeSpaceRequiredInKb;
			}
			set
			{
				this._freeSpaceRequiredInKb = value;
			}
		}
		public StorageRequirement_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
