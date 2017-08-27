namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceCannotEditMem : VmConfigFault
	{
		protected string _vmName;
		protected ManagedObjectReference _vm;
		protected FaultToleranceCannotEditMem_LinkedView _linkedView;
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
		public FaultToleranceCannotEditMem_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
