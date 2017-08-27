namespace EnvironmentAssessment.Common.VimApi
{
	public class FailToLockFaultToleranceVMs : RuntimeFault
	{
		protected string _vmName;
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _alreadyLockedVm;
		protected FailToLockFaultToleranceVMs_LinkedView _linkedView;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
		public ManagedObjectReference Vm
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
		public ManagedObjectReference AlreadyLockedVm
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
		public FailToLockFaultToleranceVMs_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
