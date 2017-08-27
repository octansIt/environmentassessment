namespace EnvironmentAssessment.Common.VimApi
{
	public class VmfsDatastoreSingleExtentOption : VmfsDatastoreBaseOption
	{
		protected HostDiskPartitionBlockRange _vmfsExtent;
		public HostDiskPartitionBlockRange VmfsExtent
		{
			get
			{
				return this._vmfsExtent;
			}
			set
			{
				this._vmfsExtent = value;
			}
		}
	}
}
