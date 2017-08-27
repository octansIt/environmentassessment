namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourceConfigOption : DynamicData
	{
		protected ResourceAllocationOption _cpuAllocationOption;
		protected ResourceAllocationOption _memoryAllocationOption;
		public ResourceAllocationOption CpuAllocationOption
		{
			get
			{
				return this._cpuAllocationOption;
			}
			set
			{
				this._cpuAllocationOption = value;
			}
		}
		public ResourceAllocationOption MemoryAllocationOption
		{
			get
			{
				return this._memoryAllocationOption;
			}
			set
			{
				this._memoryAllocationOption = value;
			}
		}
	}
}
