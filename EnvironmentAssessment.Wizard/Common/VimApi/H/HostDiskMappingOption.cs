namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiskMappingOption : DynamicData
	{
		protected HostDiskMappingPartitionOption[] _physicalPartition;
		protected string _name;
		public HostDiskMappingPartitionOption[] PhysicalPartition
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
	}
}
