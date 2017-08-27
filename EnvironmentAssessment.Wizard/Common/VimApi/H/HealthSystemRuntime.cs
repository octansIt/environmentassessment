namespace EnvironmentAssessment.Common.VimApi
{
	public class HealthSystemRuntime : DynamicData
	{
		protected HostSystemHealthInfo _systemHealthInfo;
		protected HostHardwareStatusInfo _hardwareStatusInfo;
		public HostSystemHealthInfo SystemHealthInfo
		{
			get
			{
				return this._systemHealthInfo;
			}
			set
			{
				this._systemHealthInfo = value;
			}
		}
		public HostHardwareStatusInfo HardwareStatusInfo
		{
			get
			{
				return this._hardwareStatusInfo;
			}
			set
			{
				this._hardwareStatusInfo = value;
			}
		}
	}
}
