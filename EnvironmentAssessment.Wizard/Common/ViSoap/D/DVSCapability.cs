namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSCapability : DynamicData
	{
		protected bool? _dvsOperationSupported;
		protected bool? _dvPortGroupOperationSupported;
		protected bool? _dvPortOperationSupported;
		protected DistributedVirtualSwitchHostProductSpec[] _compatibleHostComponentProductInfo;
		protected DVSFeatureCapability _featuresSupported;
		public bool? DvsOperationSupported
		{
			get
			{
				return this._dvsOperationSupported;
			}
			set
			{
				this._dvsOperationSupported = value;
			}
		}
		public bool? DvPortGroupOperationSupported
		{
			get
			{
				return this._dvPortGroupOperationSupported;
			}
			set
			{
				this._dvPortGroupOperationSupported = value;
			}
		}
		public bool? DvPortOperationSupported
		{
			get
			{
				return this._dvPortOperationSupported;
			}
			set
			{
				this._dvPortOperationSupported = value;
			}
		}
		public DistributedVirtualSwitchHostProductSpec[] CompatibleHostComponentProductInfo
		{
			get
			{
				return this._compatibleHostComponentProductInfo;
			}
			set
			{
				this._compatibleHostComponentProductInfo = value;
			}
		}
		public DVSFeatureCapability FeaturesSupported
		{
			get
			{
				return this._featuresSupported;
			}
			set
			{
				this._featuresSupported = value;
			}
		}
	}
}
