namespace EnvironmentAssessment.Common.VimApi
{
	public class EVCModeIllegalByVendor : EVCConfigFault
	{
		protected string _clusterCPUVendor;
		protected string _modeCPUVendor;
		public string ClusterCPUVendor
		{
			get
			{
				return this._clusterCPUVendor;
			}
			set
			{
				this._clusterCPUVendor = value;
			}
		}
		public string ModeCPUVendor
		{
			get
			{
				return this._modeCPUVendor;
			}
			set
			{
				this._modeCPUVendor = value;
			}
		}
	}
}
