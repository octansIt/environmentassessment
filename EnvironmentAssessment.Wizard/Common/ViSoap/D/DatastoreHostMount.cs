namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreHostMount : DynamicData
	{
		protected ManagedObjectReference _key;
		protected HostMountInfo _mountInfo;
		protected DatastoreHostMount_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public HostMountInfo MountInfo
		{
			get
			{
				return this._mountInfo;
			}
			set
			{
				this._mountInfo = value;
			}
		}
		public DatastoreHostMount_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
