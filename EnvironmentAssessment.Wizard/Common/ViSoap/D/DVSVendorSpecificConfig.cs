namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSVendorSpecificConfig : InheritablePolicy
	{
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _keyValue;
		public DistributedVirtualSwitchKeyedOpaqueBlob[] KeyValue
		{
			get
			{
				return this._keyValue;
			}
			set
			{
				this._keyValue = value;
			}
		}
	}
}
