namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageIOAllocationOption : DynamicData
	{
		protected LongOption _limitOption;
		protected SharesOption _sharesOption;
		public LongOption LimitOption
		{
			get
			{
				return this._limitOption;
			}
			set
			{
				this._limitOption = value;
			}
		}
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
