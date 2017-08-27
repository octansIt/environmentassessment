namespace EnvironmentAssessment.Common.VimApi
{
	public class FileTooLarge : FileFault
	{
		protected string _datastore;
		protected long _fileSize;
		protected long? _maxFileSize;
		public string Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public long FileSize
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
		public long? MaxFileSize
		{
			get
			{
				return this._maxFileSize;
			}
			set
			{
				this._maxFileSize = value;
			}
		}
	}
}
