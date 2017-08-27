namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo : DynamicData
	{
		protected int _numVcpus;
		protected int _cpuMHz;
		protected int _memoryMB;
		public int NumVcpus
		{
			get
			{
				return this._numVcpus;
			}
			set
			{
				this._numVcpus = value;
			}
		}
		public int CpuMHz
		{
			get
			{
				return this._cpuMHz;
			}
			set
			{
				this._cpuMHz = value;
			}
		}
		public int MemoryMB
		{
			get
			{
				return this._memoryMB;
			}
			set
			{
				this._memoryMB = value;
			}
		}
	}
}
