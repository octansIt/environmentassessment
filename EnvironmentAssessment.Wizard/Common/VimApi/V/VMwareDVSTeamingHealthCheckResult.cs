namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSTeamingHealthCheckResult : HostMemberHealthCheckResult
	{
		protected string _teamingStatus;
		public string TeamingStatus
		{
			get
			{
				return this._teamingStatus;
			}
			set
			{
				this._teamingStatus = value;
			}
		}
	}
}
