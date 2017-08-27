namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementRankSpec_LinkedView
	{
		protected ClusterComputeResource[] _clusters;
		public ClusterComputeResource[] Clusters
		{
			get
			{
				return this._clusters;
			}
			set
			{
				this._clusters = value;
			}
		}
	}
}
