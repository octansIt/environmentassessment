namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsIoLoadBalanceConfig : DynamicData
	{
		protected int? _reservablePercentThreshold;
		protected int? _reservableIopsThreshold;
		protected string _reservableThresholdMode;
		protected int? _ioLatencyThreshold;
		protected int? _ioLoadImbalanceThreshold;
		public int? ReservablePercentThreshold
		{
			get
			{
				return this._reservablePercentThreshold;
			}
			set
			{
				this._reservablePercentThreshold = value;
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
		public string ReservableThresholdMode
		{
			get
			{
				return this._reservableThresholdMode;
			}
			set
			{
				this._reservableThresholdMode = value;
			}
		}
		public int? IoLatencyThreshold
		{
			get
			{
				return this._ioLatencyThreshold;
			}
			set
			{
				this._ioLatencyThreshold = value;
			}
		}
		public int? IoLoadImbalanceThreshold
		{
			get
			{
				return this._ioLoadImbalanceThreshold;
			}
			set
			{
				this._ioLoadImbalanceThreshold = value;
			}
		}
	}
}
