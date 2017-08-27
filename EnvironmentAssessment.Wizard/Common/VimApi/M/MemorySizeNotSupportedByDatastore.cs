namespace EnvironmentAssessment.Common.VimApi
{
	public class MemorySizeNotSupportedByDatastore : VirtualHardwareCompatibilityIssue
	{
		protected ManagedObjectReference _datastore;
		protected int _memorySizeMB;
		protected int _maxMemorySizeMB;
		protected MemorySizeNotSupportedByDatastore_LinkedView _linkedView;
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
		public int MemorySizeMB
		{
			get
			{
				return this._memorySizeMB;
			}
			set
			{
				this._memorySizeMB = value;
			}
		}
		public int MaxMemorySizeMB
		{
			get
			{
				return this._maxMemorySizeMB;
			}
			set
			{
				this._maxMemorySizeMB = value;
			}
		}
		public MemorySizeNotSupportedByDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
