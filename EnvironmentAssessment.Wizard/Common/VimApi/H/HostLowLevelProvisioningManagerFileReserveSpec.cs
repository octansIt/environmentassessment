namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerFileReserveSpec : DynamicData
	{
		protected string _baseName;
		protected string _parentDir;
		protected string _fileType;
		protected string _storageProfile;
		public string BaseName
		{
			get
			{
				return this._baseName;
			}
			set
			{
				this._baseName = value;
			}
		}
		public string ParentDir
		{
			get
			{
				return this._parentDir;
			}
			set
			{
				this._parentDir = value;
			}
		}
		public string FileType
		{
			get
			{
				return this._fileType;
			}
			set
			{
				this._fileType = value;
			}
		}
		public string StorageProfile
		{
			get
			{
				return this._storageProfile;
			}
			set
			{
				this._storageProfile = value;
			}
		}
	}
}
