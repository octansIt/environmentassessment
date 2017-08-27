namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageIORMConfigOption : DynamicData
	{
		protected BoolOption _enabledOption;
		protected IntOption _congestionThresholdOption;
		protected BoolOption _statsCollectionEnabledOption;
		protected BoolOption _reservationEnabledOption;
		public BoolOption EnabledOption
		{
			get
			{
				return this._enabledOption;
			}
			set
			{
				this._enabledOption = value;
			}
		}
		public IntOption CongestionThresholdOption
		{
			get
			{
				return this._congestionThresholdOption;
			}
			set
			{
				this._congestionThresholdOption = value;
			}
		}
		public BoolOption StatsCollectionEnabledOption
		{
			get
			{
				return this._statsCollectionEnabledOption;
			}
			set
			{
				this._statsCollectionEnabledOption = value;
			}
		}
		public BoolOption ReservationEnabledOption
		{
			get
			{
				return this._reservationEnabledOption;
			}
			set
			{
				this._reservationEnabledOption = value;
			}
		}
	}
}
