namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterEnterMaintenanceResult : DynamicData
	{
		protected ClusterRecommendation[] _recommendations;
		protected ClusterDrsFaults _fault;
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
		public ClusterDrsFaults Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
