namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsUpgradeRejectedEvent : DvsEvent
	{
		protected DistributedVirtualSwitchProductSpec _productInfo;
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
	}
}
