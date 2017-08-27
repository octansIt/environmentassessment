namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasDataSummary : ClusterDasData
	{
		protected long _hostListVersion;
		protected long _clusterConfigVersion;
		protected long _compatListVersion;
		public long HostListVersion
		{
			get
			{
				return this._hostListVersion;
			}
			set
			{
				this._hostListVersion = value;
			}
		}
		public long ClusterConfigVersion
		{
			get
			{
				return this._clusterConfigVersion;
			}
			set
			{
				this._clusterConfigVersion = value;
			}
		}
		public long CompatListVersion
		{
			get
			{
				return this._compatListVersion;
			}
			set
			{
				this._compatListVersion = value;
			}
		}
	}
}
