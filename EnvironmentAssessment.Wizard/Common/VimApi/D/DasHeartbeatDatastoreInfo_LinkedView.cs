namespace EnvironmentAssessment.Common.VimApi
{
	public class DasHeartbeatDatastoreInfo_LinkedView
	{
		protected Datastore _datastore;
		protected HostSystem[] _hosts;
		public Datastore Datastore
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
		public HostSystem[] Hosts
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
	}
}
