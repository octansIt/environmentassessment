namespace EnvironmentAssessment.Common.VimApi
{
	public class PassiveNodeDeploymentSpec : NodeDeploymentSpec
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
		public new PassiveNodeDeploymentSpec_LinkedView LinkedView
		{
			get
			{
				return (PassiveNodeDeploymentSpec_LinkedView)this._linkedView;
			}
		}
	}
}
