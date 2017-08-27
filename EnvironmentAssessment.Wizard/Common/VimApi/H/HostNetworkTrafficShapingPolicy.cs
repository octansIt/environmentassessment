namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkTrafficShapingPolicy : DynamicData
	{
		protected bool? _enabled;
		protected long? _averageBandwidth;
		protected long? _peakBandwidth;
		protected long? _burstSize;
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
		public long? AverageBandwidth
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
		public long? PeakBandwidth
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
		public long? BurstSize
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
