namespace EnvironmentAssessment.Common.VimApi
{
	public class VmfsDatastoreMultipleExtentOption : VmfsDatastoreBaseOption
	{
		protected HostDiskPartitionBlockRange[] _vmfsExtent;
		public HostDiskPartitionBlockRange[] VmfsExtent
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
