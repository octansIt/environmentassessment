namespace EnvironmentAssessment.Common.VISoap
{
    public class EVCAdmissionFailedCPUVendor : EVCAdmissionFailed
	{
		protected string _clusterCPUVendor;
		protected string _hostCPUVendor;
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
		public string HostCPUVendor
		{
			get
			{
				return this._hostCPUVendor;
			}
			set
			{
				this._hostCPUVendor = value;
			}
		}
	}
}
