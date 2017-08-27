namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineUsageOnDatastore : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected long _committed;
		protected long _uncommitted;
		protected long _unshared;
		protected VirtualMachineUsageOnDatastore_LinkedView _linkedView;
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
		public long Committed
		{
			get
			{
				return this._committed;
			}
			set
			{
				this._committed = value;
			}
		}
		public long Uncommitted
		{
			get
			{
				return this._uncommitted;
			}
			set
			{
				this._uncommitted = value;
			}
		}
		public long Unshared
		{
			get
			{
				return this._unshared;
			}
			set
			{
				this._unshared = value;
			}
		}
		public VirtualMachineUsageOnDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
