namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterDeploymentSpec : DynamicData
	{
		protected PassiveNodeDeploymentSpec _passiveDeploymentSpec;
		protected NodeDeploymentSpec _witnessDeploymentSpec;
		protected SourceNodeSpec _activeVcSpec;
		protected ClusterNetworkConfigSpec _activeVcNetworkConfig;
		public PassiveNodeDeploymentSpec PassiveDeploymentSpec
		{
			get
			{
				return this._passiveDeploymentSpec;
			}
			set
			{
				this._passiveDeploymentSpec = value;
			}
		}
		public NodeDeploymentSpec WitnessDeploymentSpec
		{
			get
			{
				return this._witnessDeploymentSpec;
			}
			set
			{
				this._witnessDeploymentSpec = value;
			}
		}
		public SourceNodeSpec ActiveVcSpec
		{
			get
			{
				return this._activeVcSpec;
			}
			set
			{
				this._activeVcSpec = value;
			}
		}
		public ClusterNetworkConfigSpec ActiveVcNetworkConfig
		{
			get
			{
				return this._activeVcNetworkConfig;
			}
			set
			{
				this._activeVcNetworkConfig = value;
			}
		}
	}
}
