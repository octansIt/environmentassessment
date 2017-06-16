namespace EnvironmentAssessment.Common.VISoap
{
    public class ResourcePoolRuntimeInfo : DynamicData
	{
		protected ResourcePoolResourceUsage _memory;
		protected ResourcePoolResourceUsage _cpu;
		protected ManagedEntityStatus _overallStatus;
		public ResourcePoolResourceUsage Memory
		{
			get
			{
				return this._memory;
			}
			set
			{
				this._memory = value;
			}
		}
		public ResourcePoolResourceUsage Cpu
		{
			get
			{
				return this._cpu;
			}
			set
			{
				this._cpu = value;
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
