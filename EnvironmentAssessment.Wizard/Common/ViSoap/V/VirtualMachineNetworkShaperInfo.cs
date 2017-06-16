namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineNetworkShaperInfo : DynamicData
	{
		protected bool? _enabled;
		protected long? _peakBps;
		protected long? _averageBps;
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
		public long? PeakBps
		{
			get
			{
				return this._peakBps;
			}
			set
			{
				this._peakBps = value;
			}
		}
		public long? AverageBps
		{
			get
			{
				return this._averageBps;
			}
			set
			{
				this._averageBps = value;
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
