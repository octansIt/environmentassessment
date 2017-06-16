namespace EnvironmentAssessment.Common.VISoap
{
    public class FileQueryFlags : DynamicData
	{
		protected bool _fileType;
		protected bool _fileSize;
		protected bool _modification;
		protected bool _fileOwner;
		public bool FileType
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
		public bool FileSize
		{
			get
			{
				return this._fileSize;
			}
			set
			{
				this._fileSize = value;
			}
		}
		public bool Modification
		{
			get
			{
				return this._modification;
			}
			set
			{
				this._modification = value;
			}
		}
		public bool FileOwner
		{
			get
			{
				return this._fileOwner;
			}
			set
			{
				this._fileOwner = value;
			}
		}
	}
}
