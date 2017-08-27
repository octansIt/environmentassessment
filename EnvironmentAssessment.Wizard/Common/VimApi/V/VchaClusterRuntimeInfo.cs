namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterRuntimeInfo : DynamicData
	{
		protected string _clusterState;
		protected VchaNodeRuntimeInfo[] _nodeInfo;
		protected string _clusterMode;
		public string ClusterState
		{
			get
			{
				return this._clusterState;
			}
			set
			{
				this._clusterState = value;
			}
		}
		public VchaNodeRuntimeInfo[] NodeInfo
		{
			get
			{
				return this._nodeInfo;
			}
			set
			{
				this._nodeInfo = value;
			}
		}
		public string ClusterMode
		{
			get
			{
				return this._clusterMode;
			}
			set
			{
				this._clusterMode = value;
			}
		}
	}
}
