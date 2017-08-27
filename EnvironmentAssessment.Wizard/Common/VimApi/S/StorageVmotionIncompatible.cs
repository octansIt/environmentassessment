namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageVmotionIncompatible : VirtualHardwareCompatibilityIssue
	{
		protected ManagedObjectReference _datastore;
		protected StorageVmotionIncompatible_LinkedView _linkedView;
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
		public StorageVmotionIncompatible_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
