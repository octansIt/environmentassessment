namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsUpgradeAvailableEvent : DvsEvent
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
