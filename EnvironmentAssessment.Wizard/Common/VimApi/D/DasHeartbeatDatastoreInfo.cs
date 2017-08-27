namespace EnvironmentAssessment.Common.VimApi
{
	public class DasHeartbeatDatastoreInfo : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected ManagedObjectReference[] _hosts;
		protected DasHeartbeatDatastoreInfo_LinkedView _linkedView;
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
		public ManagedObjectReference[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
		public DasHeartbeatDatastoreInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
