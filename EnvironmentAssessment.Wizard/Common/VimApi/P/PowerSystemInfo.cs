namespace EnvironmentAssessment.Common.VimApi
{
	public class PowerSystemInfo : DynamicData
	{
		protected HostPowerPolicy _currentPolicy;
		public HostPowerPolicy CurrentPolicy
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
	}
}
