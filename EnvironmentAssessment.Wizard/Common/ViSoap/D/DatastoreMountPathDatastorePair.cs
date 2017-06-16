namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreMountPathDatastorePair : DynamicData
	{
		protected string _oldMountPath;
		protected ManagedObjectReference _datastore;
		protected DatastoreMountPathDatastorePair_LinkedView _linkedView;
		public string OldMountPath
		{
			get
			{
				return this._oldMountPath;
			}
			set
			{
				this._oldMountPath = value;
			}
		}
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
		public DatastoreMountPathDatastorePair_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
