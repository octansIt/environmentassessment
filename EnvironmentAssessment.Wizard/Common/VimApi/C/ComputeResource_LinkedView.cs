namespace EnvironmentAssessment.Common.VimApi
{
	public class ComputeResource_LinkedView : ManagedEntity_LinkedView
	{
		protected ResourcePool _resourcePool;
		protected HostSystem[] _host;
		protected Datastore[] _datastore;
		protected Network[] _network;
		protected EnvironmentBrowser _environmentBrowser;
		public ResourcePool ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public HostSystem[] Host
		{
			get
			{
				return this._host;
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
		public EnvironmentBrowser EnvironmentBrowser
		{
			get
			{
				return this._environmentBrowser;
			}
		}
	}
}
