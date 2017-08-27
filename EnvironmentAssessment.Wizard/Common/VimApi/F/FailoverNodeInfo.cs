namespace EnvironmentAssessment.Common.VimApi
{
	public class FailoverNodeInfo : DynamicData
	{
		protected CustomizationIPSettings _clusterIpSettings;
		protected CustomizationIPSettings _failoverIp;
		protected string _biosUuid;
		public CustomizationIPSettings ClusterIpSettings
		{
			get
			{
				return this._clusterIpSettings;
			}
			set
			{
				this._clusterIpSettings = value;
			}
		}
		public CustomizationIPSettings FailoverIp
		{
			get
			{
				return this._failoverIp;
			}
			set
			{
				this._failoverIp = value;
			}
		}
		public string BiosUuid
		{
			get
			{
				return this._biosUuid;
			}
			set
			{
				this._biosUuid = value;
			}
		}
	}
}
