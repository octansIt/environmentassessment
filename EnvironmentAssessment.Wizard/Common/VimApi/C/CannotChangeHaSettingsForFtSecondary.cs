namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotChangeHaSettingsForFtSecondary : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected CannotChangeHaSettingsForFtSecondary_LinkedView _linkedView;
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
		public CannotChangeHaSettingsForFtSecondary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
