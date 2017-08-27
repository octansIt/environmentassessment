namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceVmNotDasProtected : VimFault
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected FaultToleranceVmNotDasProtected_LinkedView _linkedView;
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
		public FaultToleranceVmNotDasProtected_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
