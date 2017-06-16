namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSystem_LinkedView : ManagedEntity_LinkedView
	{
		protected VirtualMachine[] _vm;
		protected Datastore[] _datastore;
		protected Network[] _network;
		protected HostDatastoreBrowser _datastoreBrowser;
		public VirtualMachine[] Vm
		{
			get
			{
				return this._vm;
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
		public HostDatastoreBrowser DatastoreBrowser
		{
			get
			{
				return this._datastoreBrowser;
			}
		}
	}
}
