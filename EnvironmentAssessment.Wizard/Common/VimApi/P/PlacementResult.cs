namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementResult : DynamicData
	{
		protected ClusterRecommendation[] _recommendations;
		protected ClusterDrsFaults _drsFault;
		public ClusterRecommendation[] Recommendations
		{
			get
			{
				return this._recommendations;
			}
			set
			{
				this._recommendations = value;
			}
		}
		public ClusterDrsFaults DrsFault
		{
			get
			{
				return this._drsFault;
			}
			set
			{
				this._drsFault = value;
			}
		}
	}
}
