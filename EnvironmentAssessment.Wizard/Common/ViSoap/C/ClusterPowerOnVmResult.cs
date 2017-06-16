namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterPowerOnVmResult : DynamicData
	{
		protected ClusterAttemptedVmInfo[] _attempted;
		protected ClusterNotAttemptedVmInfo[] _notAttempted;
		protected ClusterRecommendation[] _recommendations;
		public ClusterAttemptedVmInfo[] Attempted
		{
			get
			{
				return this._attempted;
			}
			set
			{
				this._attempted = value;
			}
		}
		public ClusterNotAttemptedVmInfo[] NotAttempted
		{
			get
			{
				return this._notAttempted;
			}
			set
			{
				this._notAttempted = value;
			}
		}
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
	}
}
