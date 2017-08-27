namespace EnvironmentAssessment.Common.VimApi
{
	public class Network_LinkedView : ManagedEntity_LinkedView
	{
		protected HostSystem[] _host;
		protected VirtualMachine[] _vm;
		public HostSystem[] Host
		{
			get
			{
				return this._host;
			}
		}
		public VirtualMachine[] Vm
		{
			get
			{
				return this._vm;
			}
		}
	}
}
