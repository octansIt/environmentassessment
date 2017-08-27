namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMemberUplinkHealthCheckResult : HostMemberHealthCheckResult
	{
		protected string _uplinkPortKey;
		public string UplinkPortKey
		{
			get
			{
				return this._uplinkPortKey;
			}
			set
			{
				this._uplinkPortKey = value;
			}
		}
	}
}
