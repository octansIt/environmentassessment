namespace EnvironmentAssessment.Common.VimApi
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
