namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskPartitionedRawDiskVer2BackingInfo : VirtualDiskRawDiskVer2BackingInfo
	{
		protected int[] _partition;
		public int[] Partition
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
