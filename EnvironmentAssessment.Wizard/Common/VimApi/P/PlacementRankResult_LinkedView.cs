namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementRankResult_LinkedView
	{
		protected ClusterComputeResource _candidate;
		public ClusterComputeResource Candidate
		{
			get
			{
				return this._candidate;
			}
			set
			{
				this._candidate = value;
			}
		}
	}
}
