namespace EnvironmentAssessment.Common.VimApi
{
	public class PowerOnFtSecondaryFailed : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected FtIssuesOnHostHostSelectionType _hostSelectionBy;
		protected LocalizedMethodFault[] _hostErrors;
		protected LocalizedMethodFault _rootCause;
		protected PowerOnFtSecondaryFailed_LinkedView _linkedView;
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
		public FtIssuesOnHostHostSelectionType HostSelectionBy
		{
			get
			{
				return this._hostSelectionBy;
			}
			set
			{
				this._hostSelectionBy = value;
			}
		}
		public LocalizedMethodFault[] HostErrors
		{
			get
			{
				return this._hostErrors;
			}
			set
			{
				this._hostErrors = value;
			}
		}
		public LocalizedMethodFault RootCause
		{
			get
			{
				return this._rootCause;
			}
			set
			{
				this._rootCause = value;
			}
		}
		public PowerOnFtSecondaryFailed_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
