namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskPartitionLayout : DynamicData
	{
		protected HostDiskDimensionsLba _total;
		protected HostDiskPartitionBlockRange[] _partition;
		public HostDiskDimensionsLba Total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
			}
		}
		public HostDiskPartitionBlockRange[] Partition
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
