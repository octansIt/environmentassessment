namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageDrsPodSelectionSpec : DynamicData
	{
		protected VmPodConfigForPlacement[] _initialVmConfig;
		protected ManagedObjectReference _storagePod;
		protected StorageDrsPodSelectionSpec_LinkedView _linkedView;
		public VmPodConfigForPlacement[] InitialVmConfig
		{
			get
			{
				return this._initialVmConfig;
			}
			set
			{
				this._initialVmConfig = value;
			}
		}
		public ManagedObjectReference StoragePod
		{
			get
			{
				return this._storagePod;
			}
			set
			{
				this._storagePod = value;
			}
		}
		public StorageDrsPodSelectionSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
