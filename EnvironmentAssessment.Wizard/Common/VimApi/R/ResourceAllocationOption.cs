namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourceAllocationOption : DynamicData
	{
		protected SharesOption _sharesOption;
		public SharesOption SharesOption
		{
			get
			{
				return this._sharesOption;
			}
			set
			{
				this._sharesOption = value;
			}
		}
	}
}
