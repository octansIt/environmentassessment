namespace EnvironmentAssessment.Common.VISoap
{
    public class ComputeResourceSummary : DynamicData
	{
		protected int _totalCpu;
		protected long _totalMemory;
		protected short _numCpuCores;
		protected short _numCpuThreads;
		protected int _effectiveCpu;
		protected long _effectiveMemory;
		protected int _numHosts;
		protected int _numEffectiveHosts;
		protected ManagedEntityStatus _overallStatus;
		public int TotalCpu
		{
			get
			{
				return this._totalCpu;
			}
			set
			{
				this._totalCpu = value;
			}
		}
		public long TotalMemory
		{
			get
			{
				return this._totalMemory;
			}
			set
			{
				this._totalMemory = value;
			}
		}
		public short NumCpuCores
		{
			get
			{
				return this._numCpuCores;
			}
			set
			{
				this._numCpuCores = value;
			}
		}
		public short NumCpuThreads
		{
			get
			{
				return this._numCpuThreads;
			}
			set
			{
				this._numCpuThreads = value;
			}
		}
		public int EffectiveCpu
		{
			get
			{
				return this._effectiveCpu;
			}
			set
			{
				this._effectiveCpu = value;
			}
		}
		public long EffectiveMemory
		{
			get
			{
				return this._effectiveMemory;
			}
			set
			{
				this._effectiveMemory = value;
			}
		}
		public int NumHosts
		{
			get
			{
				return this._numHosts;
			}
			set
			{
				this._numHosts = value;
			}
		}
		public int NumEffectiveHosts
		{
			get
			{
				return this._numEffectiveHosts;
			}
			set
			{
				this._numEffectiveHosts = value;
			}
		}
		public ManagedEntityStatus OverallStatus
		{
			get
			{
				return this._overallStatus;
			}
			set
			{
				this._overallStatus = value;
			}
		}
	}
}
