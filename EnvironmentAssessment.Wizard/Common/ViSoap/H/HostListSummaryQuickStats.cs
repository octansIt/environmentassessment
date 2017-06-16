namespace EnvironmentAssessment.Common.VISoap
{
    public class HostListSummaryQuickStats : DynamicData
	{
		protected int? _overallCpuUsage;
		protected int? _overallMemoryUsage;
		protected int? _distributedCpuFairness;
		protected int? _distributedMemoryFairness;
		protected int? _uptime;
		public int? OverallCpuUsage
		{
			get
			{
				return this._overallCpuUsage;
			}
			set
			{
				this._overallCpuUsage = value;
			}
		}
		public int? OverallMemoryUsage
		{
			get
			{
				return this._overallMemoryUsage;
			}
			set
			{
				this._overallMemoryUsage = value;
			}
		}
		public int? DistributedCpuFairness
		{
			get
			{
				return this._distributedCpuFairness;
			}
			set
			{
				this._distributedCpuFairness = value;
			}
		}
		public int? DistributedMemoryFairness
		{
			get
			{
				return this._distributedMemoryFairness;
			}
			set
			{
				this._distributedMemoryFairness = value;
			}
		}
		public int? Uptime
		{
			get
			{
				return this._uptime;
			}
			set
			{
				this._uptime = value;
			}
		}
	}
}
