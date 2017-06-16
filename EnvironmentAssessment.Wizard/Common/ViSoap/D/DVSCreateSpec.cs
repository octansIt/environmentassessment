namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSCreateSpec : DynamicData
	{
		protected DVSConfigSpec _configSpec;
		protected DistributedVirtualSwitchProductSpec _productInfo;
		protected DVSCapability _capability;
		public DVSConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public DistributedVirtualSwitchProductSpec ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
		public DVSCapability Capability
		{
			get
			{
				return this._capability;
			}
			set
			{
				this._capability = value;
			}
		}
	}
}
