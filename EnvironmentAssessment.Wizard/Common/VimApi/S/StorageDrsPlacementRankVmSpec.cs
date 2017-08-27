namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsPlacementRankVmSpec : DynamicData
	{
		protected PlacementSpec _vmPlacementSpec;
		protected ManagedObjectReference[] _vmClusters;
		protected StorageDrsPlacementRankVmSpec_LinkedView _linkedView;
		public PlacementSpec VmPlacementSpec
		{
			get
			{
				return this._vmPlacementSpec;
			}
			set
			{
				this._vmPlacementSpec = value;
			}
		}
		public ManagedObjectReference[] VmClusters
		{
			get
			{
				return this._vmClusters;
			}
			set
			{
				this._vmClusters = value;
			}
		}
		public StorageDrsPlacementRankVmSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
