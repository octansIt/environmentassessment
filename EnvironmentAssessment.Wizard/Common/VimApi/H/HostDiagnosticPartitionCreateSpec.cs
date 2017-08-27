namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiagnosticPartitionCreateSpec : DynamicData
	{
		protected string _storageType;
		protected string _diagnosticType;
		protected HostScsiDiskPartition _id;
		protected HostDiskPartitionSpec _partition;
		protected bool? _active;
		public string StorageType
		{
			get
			{
				return this._storageType;
			}
			set
			{
				this._storageType = value;
			}
		}
		public string DiagnosticType
		{
			get
			{
				return this._diagnosticType;
			}
			set
			{
				this._diagnosticType = value;
			}
		}
		public HostScsiDiskPartition Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
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
		public bool? Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
	}
}
