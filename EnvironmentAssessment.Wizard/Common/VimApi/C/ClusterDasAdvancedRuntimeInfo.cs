namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasAdvancedRuntimeInfo : DynamicData
	{
		protected ClusterDasHostInfo _dasHostInfo;
		protected ClusterDasAdvancedRuntimeInfoVmcpCapabilityInfo _vmcpSupported;
		protected DasHeartbeatDatastoreInfo[] _heartbeatDatastoreInfo;
		public ClusterDasHostInfo DasHostInfo
		{
			get
			{
				return this._dasHostInfo;
			}
			set
			{
				this._dasHostInfo = value;
			}
		}
		public ClusterDasAdvancedRuntimeInfoVmcpCapabilityInfo VmcpSupported
		{
			get
			{
				return this._vmcpSupported;
			}
			set
			{
				this._vmcpSupported = value;
			}
		}
		public DasHeartbeatDatastoreInfo[] HeartbeatDatastoreInfo
		{
			get
			{
				return this._heartbeatDatastoreInfo;
			}
			set
			{
				this._heartbeatDatastoreInfo = value;
			}
		}
	}
}
