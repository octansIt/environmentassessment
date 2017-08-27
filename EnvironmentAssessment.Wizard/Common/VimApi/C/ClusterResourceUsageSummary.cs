namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterResourceUsageSummary : DynamicData
	{
		protected int _cpuUsedMHz;
		protected int _cpuCapacityMHz;
		protected int _memUsedMB;
		protected int _memCapacityMB;
		protected long _storageUsedMB;
		protected long _storageCapacityMB;
		public int CpuUsedMHz
		{
			get
			{
				return this._cpuUsedMHz;
			}
			set
			{
				this._cpuUsedMHz = value;
			}
		}
		public int CpuCapacityMHz
		{
			get
			{
				return this._cpuCapacityMHz;
			}
			set
			{
				this._cpuCapacityMHz = value;
			}
		}
		public int MemUsedMB
		{
			get
			{
				return this._memUsedMB;
			}
			set
			{
				this._memUsedMB = value;
			}
		}
		public int MemCapacityMB
		{
			get
			{
				return this._memCapacityMB;
			}
			set
			{
				this._memCapacityMB = value;
			}
		}
		public long StorageUsedMB
		{
			get
			{
				return this._storageUsedMB;
			}
			set
			{
				this._storageUsedMB = value;
			}
		}
		public long StorageCapacityMB
		{
			get
			{
				return this._storageCapacityMB;
			}
			set
			{
				this._storageCapacityMB = value;
			}
		}
	}
}
