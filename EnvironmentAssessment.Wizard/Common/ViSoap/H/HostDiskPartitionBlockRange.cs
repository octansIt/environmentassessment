namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskPartitionBlockRange : DynamicData
	{
		protected int? _partition;
		protected string _type;
		protected HostDiskDimensionsLba _start;
		protected HostDiskDimensionsLba _end;
		public int? Partition
		{
			get
			{
				return this._partition;
			}
			set
			{
				this._partition = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public HostDiskDimensionsLba Start
		{
			get
			{
				return this._start;
			}
			set
			{
				this._start = value;
			}
		}
		public HostDiskDimensionsLba End
		{
			get
			{
				return this._end;
			}
			set
			{
				this._end = value;
			}
		}
	}
}
