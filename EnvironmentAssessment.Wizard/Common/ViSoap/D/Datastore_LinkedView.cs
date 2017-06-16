namespace EnvironmentAssessment.Common.VISoap
{
    public class Datastore_LinkedView : ManagedEntity_LinkedView
	{
		protected VirtualMachine[] _vm;
		protected HostDatastoreBrowser _browser;
		public VirtualMachine[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public HostDatastoreBrowser Browser
		{
			get
			{
				return this._browser;
			}
		}
	}
}
