namespace EnvironmentAssessment.Common.VISoap
{
    public class PowerSystemCapability : DynamicData
	{
		protected HostPowerPolicy[] _availablePolicy;
		public HostPowerPolicy[] AvailablePolicy
		{
			get
			{
				return this._availablePolicy;
			}
			set
			{
				this._availablePolicy = value;
			}
		}
	}
}
