namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterFailoverResourcesAdmissionControlPolicy : ClusterDasAdmissionControlPolicy
	{
		protected int _cpuFailoverResourcesPercent;
		protected int _memoryFailoverResourcesPercent;
		protected int? _failoverLevel;
		protected bool? _autoComputePercentages;
		public int CpuFailoverResourcesPercent
		{
			get
			{
				return this._cpuFailoverResourcesPercent;
			}
			set
			{
				this._cpuFailoverResourcesPercent = value;
			}
		}
		public int MemoryFailoverResourcesPercent
		{
			get
			{
				return this._memoryFailoverResourcesPercent;
			}
			set
			{
				this._memoryFailoverResourcesPercent = value;
			}
		}
		public int? FailoverLevel
		{
			get
			{
				return this._failoverLevel;
			}
			set
			{
				this._failoverLevel = value;
			}
		}
		public bool? AutoComputePercentages
		{
			get
			{
				return this._autoComputePercentages;
			}
			set
			{
				this._autoComputePercentages = value;
			}
		}
	}
}
