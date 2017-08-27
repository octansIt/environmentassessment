namespace EnvironmentAssessment.Common.VimApi
{
	public class PassiveNodeNetworkSpec : NodeNetworkSpec
	{
		protected CustomizationIPSettings _failoverIpSettings;
		public CustomizationIPSettings FailoverIpSettings
		{
			get
			{
				return this._failoverIpSettings;
			}
			set
			{
				this._failoverIpSettings = value;
			}
		}
	}
}
