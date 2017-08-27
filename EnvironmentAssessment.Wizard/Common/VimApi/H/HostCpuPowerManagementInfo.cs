namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCpuPowerManagementInfo : DynamicData
	{
		protected string _currentPolicy;
		protected string _hardwareSupport;
		public string CurrentPolicy
		{
			get
			{
				return this._currentPolicy;
			}
			set
			{
				this._currentPolicy = value;
			}
		}
		public string HardwareSupport
		{
			get
			{
				return this._hardwareSupport;
			}
			set
			{
				this._hardwareSupport = value;
			}
		}
	}
}
