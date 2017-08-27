namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiskPartitionSpec : DynamicData
	{
		protected string _partitionFormat;
		protected HostDiskDimensionsChs _chs;
		protected long? _totalSectors;
		protected HostDiskPartitionAttributes[] _partition;
		public string PartitionFormat
		{
			get
			{
				return this._partitionFormat;
			}
			set
			{
				this._partitionFormat = value;
			}
		}
		public HostDiskDimensionsChs Chs
		{
			get
			{
				return this._chs;
			}
			set
			{
				this._chs = value;
			}
		}
		public long? TotalSectors
		{
			get
			{
				return this._totalSectors;
			}
			set
			{
				this._totalSectors = value;
			}
		}
		public HostDiskPartitionAttributes[] Partition
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
	}
}
