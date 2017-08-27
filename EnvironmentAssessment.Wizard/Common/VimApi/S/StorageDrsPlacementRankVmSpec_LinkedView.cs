namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsPlacementRankVmSpec_LinkedView
	{
		protected ClusterComputeResource[] _vmClusters;
		public ClusterComputeResource[] VmClusters
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
	}
}
