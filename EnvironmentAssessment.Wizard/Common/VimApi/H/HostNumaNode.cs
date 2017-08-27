namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNumaNode : DynamicData
	{
		protected sbyte _typeId;
		protected short[] _cpuID;
		protected long _memoryRangeBegin;
		protected long _memoryRangeLength;
		public sbyte TypeId
		{
			get
			{
				return this._typeId;
			}
			set
			{
				this._typeId = value;
			}
		}
		public short[] CpuID
		{
			get
			{
				return this._cpuID;
			}
			set
			{
				this._cpuID = value;
			}
		}
		public long MemoryRangeBegin
		{
			get
			{
				return this._memoryRangeBegin;
			}
			set
			{
				this._memoryRangeBegin = value;
			}
		}
		public long MemoryRangeLength
		{
			get
			{
				return this._memoryRangeLength;
			}
			set
			{
				this._memoryRangeLength = value;
			}
		}
	}
}
