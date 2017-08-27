namespace EnvironmentAssessment.Common.VimApi
{
	public class HostHardwareStatusInfo : DynamicData
	{
		protected HostHardwareElementInfo[] _memoryStatusInfo;
		protected HostHardwareElementInfo[] _cpuStatusInfo;
		protected HostStorageElementInfo[] _storageStatusInfo;
		public HostHardwareElementInfo[] MemoryStatusInfo
		{
			get
			{
				return this._memoryStatusInfo;
			}
			set
			{
				this._memoryStatusInfo = value;
			}
		}
		public HostHardwareElementInfo[] CpuStatusInfo
		{
			get
			{
				return this._cpuStatusInfo;
			}
			set
			{
				this._cpuStatusInfo = value;
			}
		}
		public HostStorageElementInfo[] StorageStatusInfo
		{
			get
			{
				return this._storageStatusInfo;
			}
			set
			{
				this._storageStatusInfo = value;
			}
		}
	}
}
