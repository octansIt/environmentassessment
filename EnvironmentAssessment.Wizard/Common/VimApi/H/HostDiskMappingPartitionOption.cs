namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiskMappingPartitionOption : DynamicData
	{
		protected string _name;
		protected string _fileSystem;
		protected long _capacityInKb;
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
		public string FileSystem
		{
			get
			{
				return this._fileSystem;
			}
			set
			{
				this._fileSystem = value;
			}
		}
		public long CapacityInKb
		{
			get
			{
				return this._capacityInKb;
			}
			set
			{
				this._capacityInKb = value;
			}
		}
	}
}
