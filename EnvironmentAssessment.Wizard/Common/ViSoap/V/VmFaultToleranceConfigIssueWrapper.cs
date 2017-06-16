namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFaultToleranceConfigIssueWrapper : VmFaultToleranceIssue
	{
		protected string _entityName;
		protected ManagedObjectReference _entity;
		protected LocalizedMethodFault _error;
		protected VmFaultToleranceConfigIssueWrapper_LinkedView _linkedView;
		public string EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				this._entityName = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public VmFaultToleranceConfigIssueWrapper_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
