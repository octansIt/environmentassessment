namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterEVCManager_LinkedView
	{
		protected ClusterComputeResource _managedCluster;
		public ClusterComputeResource ManagedCluster
		{
			get
			{
				return this._managedCluster;
			}
		}
	}
}
