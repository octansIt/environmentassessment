namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotComputeFTCompatibleHosts : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected CannotComputeFTCompatibleHosts_LinkedView _linkedView;
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
		public CannotComputeFTCompatibleHosts_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
