namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverResourcesAdmissionControlPolicy : ClusterDasAdmissionControlPolicy
	{
		protected int _cpuFailoverResourcesPercent;
		protected int _memoryFailoverResourcesPercent;
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
	}
}
