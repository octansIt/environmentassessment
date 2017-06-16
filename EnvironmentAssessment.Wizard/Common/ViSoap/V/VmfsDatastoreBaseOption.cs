namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreBaseOption : DynamicData
	{
		protected HostDiskPartitionLayout _layout;
		protected bool? _partitionFormatChange;
		public HostDiskPartitionLayout Layout
		{
			get
			{
				return this._layout;
			}
			set
			{
				this._layout = value;
			}
		}
		public bool? PartitionFormatChange
		{
			get
			{
				return this._partitionFormatChange;
			}
			set
			{
				this._partitionFormatChange = value;
			}
		}
	}
}
