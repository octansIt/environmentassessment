namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiagnosticPartitionCreateOption : DynamicData
	{
		protected string _storageType;
		protected string _diagnosticType;
		protected HostScsiDisk _disk;
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
		public HostScsiDisk Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
	}
}
