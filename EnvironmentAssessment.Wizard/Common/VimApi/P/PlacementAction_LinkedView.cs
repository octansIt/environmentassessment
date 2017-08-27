namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementAction_LinkedView
	{
		protected VirtualMachine _vm;
		protected HostSystem _targetHost;
		public VirtualMachine Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public HostSystem TargetHost
		{
			get
			{
				return this._targetHost;
			}
			set
			{
				this._targetHost = value;
			}
		}
	}
}
