namespace EnvironmentAssessment.Common.VimApi
{
	public class FailToLockFaultToleranceVMs_LinkedView
	{
		protected VirtualMachine _vm;
		protected VirtualMachine _alreadyLockedVm;
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
		public VirtualMachine AlreadyLockedVm
		{
			get
			{
				return this._alreadyLockedVm;
			}
			set
			{
				this._alreadyLockedVm = value;
			}
		}
	}
}
