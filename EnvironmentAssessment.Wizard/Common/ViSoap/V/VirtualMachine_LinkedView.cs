namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachine_LinkedView : ManagedEntity_LinkedView
	{
		protected EnvironmentBrowser _environmentBrowser;
		protected ResourcePool _resourcePool;
		protected ManagedEntity _parentVApp;
		protected Datastore[] _datastore;
		protected Network[] _network;
		protected VirtualMachineSnapshot[] _rootSnapshot;
		public EnvironmentBrowser EnvironmentBrowser
		{
			get
			{
				return this._environmentBrowser;
			}
		}
		public ResourcePool ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public ManagedEntity ParentVApp
		{
			get
			{
				return this._parentVApp;
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
		public VirtualMachineSnapshot[] RootSnapshot
		{
			get
			{
				return this._rootSnapshot;
			}
		}
	}
}
