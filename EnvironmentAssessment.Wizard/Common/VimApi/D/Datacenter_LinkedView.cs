namespace EnvironmentAssessment.Common.VimApi
{
	public class Datacenter_LinkedView : ManagedEntity_LinkedView
	{
		protected Folder _vmFolder;
		protected Folder _hostFolder;
		protected Folder _datastoreFolder;
		protected Folder _networkFolder;
		protected Datastore[] _datastore;
		protected Network[] _network;
		public Folder VmFolder
		{
			get
			{
				return this._vmFolder;
			}
		}
		public Folder HostFolder
		{
			get
			{
				return this._hostFolder;
			}
		}
		public Folder DatastoreFolder
		{
			get
			{
				return this._datastoreFolder;
			}
		}
		public Folder NetworkFolder
		{
			get
			{
				return this._networkFolder;
			}
		}
		public Datastore[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public Network[] Network
		{
			get
			{
				return this._network;
			}
		}
	}
}
