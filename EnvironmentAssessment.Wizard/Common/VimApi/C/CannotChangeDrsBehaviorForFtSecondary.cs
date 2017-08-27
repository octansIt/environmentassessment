namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotChangeDrsBehaviorForFtSecondary : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected CannotChangeDrsBehaviorForFtSecondary_LinkedView _linkedView;
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
		public CannotChangeDrsBehaviorForFtSecondary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
