namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageIORMConfigSpec : DynamicData
	{
		protected bool? _enabled;
		protected string _congestionThresholdMode;
		protected int? _congestionThreshold;
		protected int? _percentOfPeakThroughput;
		protected bool? _statsCollectionEnabled;
		protected bool? _reservationEnabled;
		protected bool? _statsAggregationDisabled;
		protected int? _reservableIopsThreshold;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public string CongestionThresholdMode
		{
			get
			{
				return this._congestionThresholdMode;
			}
			set
			{
				this._congestionThresholdMode = value;
			}
		}
		public int? CongestionThreshold
		{
			get
			{
				return this._congestionThreshold;
			}
			set
			{
				this._congestionThreshold = value;
			}
		}
		public int? PercentOfPeakThroughput
		{
			get
			{
				return this._percentOfPeakThroughput;
			}
			set
			{
				this._percentOfPeakThroughput = value;
			}
		}
		public bool? StatsCollectionEnabled
		{
			get
			{
				return this._statsCollectionEnabled;
			}
			set
			{
				this._statsCollectionEnabled = value;
			}
		}
		public bool? ReservationEnabled
		{
			get
			{
				return this._reservationEnabled;
			}
			set
			{
				this._reservationEnabled = value;
			}
		}
		public bool? StatsAggregationDisabled
		{
			get
			{
				return this._statsAggregationDisabled;
			}
			set
			{
				this._statsAggregationDisabled = value;
			}
		}
		public int? ReservableIopsThreshold
		{
			get
			{
				return this._reservableIopsThreshold;
			}
			set
			{
				this._reservableIopsThreshold = value;
			}
		}
	}
}
