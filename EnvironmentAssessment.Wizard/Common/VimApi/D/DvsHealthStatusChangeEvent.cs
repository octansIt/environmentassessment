namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsHealthStatusChangeEvent : HostEvent
	{
		protected string _switchUuid;
		protected HostMemberHealthCheckResult _healthResult;
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
		public HostMemberHealthCheckResult HealthResult
		{
			get
			{
				return this._healthResult;
			}
			set
			{
				this._healthResult = value;
			}
		}
	}
}
