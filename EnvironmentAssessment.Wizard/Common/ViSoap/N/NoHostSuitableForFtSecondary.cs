namespace EnvironmentAssessment.Common.VISoap
{
    public class NoHostSuitableForFtSecondary : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected NoHostSuitableForFtSecondary_LinkedView _linkedView;
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
		public NoHostSuitableForFtSecondary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
