namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceDiskSpec : DynamicData
	{
		protected VirtualDevice _disk;
		protected ManagedObjectReference _datastore;
		protected FaultToleranceDiskSpec_LinkedView _linkedView;
		public VirtualDevice Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
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
		public FaultToleranceDiskSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
