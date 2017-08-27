namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterVmOrchestrationSpec : ArrayUpdateSpec
	{
		protected ClusterVmOrchestrationInfo _info;
		public ClusterVmOrchestrationInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
