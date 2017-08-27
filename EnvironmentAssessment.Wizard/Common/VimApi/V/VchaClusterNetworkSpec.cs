namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterNetworkSpec : DynamicData
	{
		protected NodeNetworkSpec _witnessNetworkSpec;
		protected PassiveNodeNetworkSpec _passiveNetworkSpec;
		public NodeNetworkSpec WitnessNetworkSpec
		{
			get
			{
				return this._witnessNetworkSpec;
			}
			set
			{
				this._witnessNetworkSpec = value;
			}
		}
		public PassiveNodeNetworkSpec PassiveNetworkSpec
		{
			get
			{
				return this._passiveNetworkSpec;
			}
			set
			{
				this._passiveNetworkSpec = value;
			}
		}
	}
}
