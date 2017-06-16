namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskMappingInfo : DynamicData
	{
		protected HostDiskMappingPartitionInfo _physicalPartition;
		protected string _name;
		protected bool? _exclusive;
		public HostDiskMappingPartitionInfo PhysicalPartition
		{
			get
			{
				return this._physicalPartition;
			}
			set
			{
				this._physicalPartition = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public bool? Exclusive
		{
			get
			{
				return this._exclusive;
			}
			set
			{
				this._exclusive = value;
			}
		}
	}
}
