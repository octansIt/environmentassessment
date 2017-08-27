namespace EnvironmentAssessment.Common.VimApi
{
	public class MemoryFileFormatNotSupportedByDatastore : UnsupportedDatastore
	{
		protected string _datastoreName;
		protected string _type;
		public string DatastoreName
		{
			get
			{
				return this._datastoreName;
			}
			set
			{
				this._datastoreName = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public new MemoryFileFormatNotSupportedByDatastore_LinkedView LinkedView
		{
			get
			{
				return (MemoryFileFormatNotSupportedByDatastore_LinkedView)this._linkedView;
			}
		}
	}
}
