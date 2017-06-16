namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSTrafficShapingPolicy : InheritablePolicy
	{
		protected BoolPolicy _enabled;
		protected LongPolicy _averageBandwidth;
		protected LongPolicy _peakBandwidth;
		protected LongPolicy _burstSize;
		public BoolPolicy Enabled
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
		public LongPolicy AverageBandwidth
		{
			get
			{
				return this._averageBandwidth;
			}
			set
			{
				this._averageBandwidth = value;
			}
		}
		public LongPolicy PeakBandwidth
		{
			get
			{
				return this._peakBandwidth;
			}
			set
			{
				this._peakBandwidth = value;
			}
		}
		public LongPolicy BurstSize
		{
			get
			{
				return this._burstSize;
			}
			set
			{
				this._burstSize = value;
			}
		}
	}
}
