namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDatastoreVolumeOption : DynamicData
	{
		protected string _fileSystemType;
		protected int? _majorVersion;
		public string FileSystemType
		{
			get
			{
				return this._fileSystemType;
			}
			set
			{
				this._fileSystemType = value;
			}
		}
		public int? MajorVersion
		{
			get
			{
				return this._majorVersion;
			}
			set
			{
				this._majorVersion = value;
			}
		}
	}
}
