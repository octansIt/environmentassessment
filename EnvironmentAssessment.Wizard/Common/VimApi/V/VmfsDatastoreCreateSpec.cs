namespace EnvironmentAssessment.Common.VimApi
{
	public class VmfsDatastoreCreateSpec : VmfsDatastoreSpec
	{
		protected HostDiskPartitionSpec _partition;
		protected HostVmfsSpec _vmfs;
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
		public HostVmfsSpec Vmfs
		{
			get
			{
				return this._vmfs;
			}
			set
			{
				this._vmfs = value;
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
