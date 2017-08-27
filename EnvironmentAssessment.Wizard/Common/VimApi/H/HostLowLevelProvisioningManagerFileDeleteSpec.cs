namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerFileDeleteSpec : DynamicData
	{
		protected string _fileName;
		protected string _fileType;
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
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
	}
}
