namespace EnvironmentAssessment.Common.VISoap
{
    public class VmPodConfigForPlacement : DynamicData
	{
		protected ManagedObjectReference _storagePod;
		protected PodDiskLocator[] _disk;
		protected StorageDrsVmConfigInfo _vmConfig;
		protected ClusterRuleInfo[] _interVmRule;
		protected VmPodConfigForPlacement_LinkedView _linkedView;
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
		public PodDiskLocator[] Disk
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
		public StorageDrsVmConfigInfo VmConfig
		{
			get
			{
				return this._vmConfig;
			}
			set
			{
				this._vmConfig = value;
			}
		}
		public ClusterRuleInfo[] InterVmRule
		{
			get
			{
				return this._interVmRule;
			}
			set
			{
				this._interVmRule = value;
			}
		}
		public VmPodConfigForPlacement_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
