namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDatastoreBrowserSearchResults : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected string _folderPath;
		protected FileInfo[] _file;
		protected HostDatastoreBrowserSearchResults_LinkedView _linkedView;
		public ManagedObjectReference Datastore
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
		public string FolderPath
		{
			get
			{
				return this._folderPath;
			}
			set
			{
				this._folderPath = value;
			}
		}
		public FileInfo[] File
		{
			get
			{
				return this._file;
			}
			set
			{
				this._file = value;
			}
		}
		public HostDatastoreBrowserSearchResults_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
