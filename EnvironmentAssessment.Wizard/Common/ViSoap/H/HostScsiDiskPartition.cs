namespace EnvironmentAssessment.Common.VISoap
{
    public class HostScsiDiskPartition : DynamicData
	{
		protected string _diskName;
		protected int _partition;
		public string DiskName
		{
			get
			{
				return this._diskName;
			}
			set
			{
				this._diskName = value;
			}
		}
		public int Partition
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
