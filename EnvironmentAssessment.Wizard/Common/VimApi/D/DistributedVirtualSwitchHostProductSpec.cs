namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostProductSpec : DynamicData
	{
		protected string _productLineId;
		protected string _version;
		public string ProductLineId
		{
			get
			{
				return this._productLineId;
			}
			set
			{
				this._productLineId = value;
			}
		}
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
	}
}
