namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterOrchestrationInfo : DynamicData
	{
		protected ClusterVmReadiness _defaultVmReadiness;
		public ClusterVmReadiness DefaultVmReadiness
		{
			get
			{
				return this._defaultVmReadiness;
			}
			set
			{
				this._defaultVmReadiness = value;
			}
		}
	}
}
