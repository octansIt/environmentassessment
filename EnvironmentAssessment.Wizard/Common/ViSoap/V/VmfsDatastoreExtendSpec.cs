namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreExtendSpec : VmfsDatastoreSpec
	{
		protected HostDiskPartitionSpec _partition;
		protected HostScsiDiskPartition[] _extent;
		public HostDiskPartitionSpec Partition
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
		public HostScsiDiskPartition[] Extent
		{
			get
			{
				return this._extent;
			}
			set
			{
				this._extent = value;
			}
		}
	}
}
