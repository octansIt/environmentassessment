namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasAdmissionControlPolicy : DynamicData
	{
		protected int? _resourceReductionToToleratePercent;
		public int? ResourceReductionToToleratePercent
		{
			get
			{
				return this._resourceReductionToToleratePercent;
			}
			set
			{
				this._resourceReductionToToleratePercent = value;
			}
		}
	}
}
