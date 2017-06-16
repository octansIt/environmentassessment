namespace EnvironmentAssessment.Common.VISoap
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
