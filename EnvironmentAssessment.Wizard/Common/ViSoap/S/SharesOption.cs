namespace EnvironmentAssessment.Common.VISoap
{
    public class SharesOption : DynamicData
	{
		protected IntOption _sharesOption;
		protected SharesLevel _defaultLevel;
		public IntOption sharesOption
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
		public SharesLevel DefaultLevel
		{
			get
			{
				return this._defaultLevel;
			}
			set
			{
				this._defaultLevel = value;
			}
		}
	}
}
