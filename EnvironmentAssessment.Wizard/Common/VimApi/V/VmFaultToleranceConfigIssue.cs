namespace EnvironmentAssessment.Common.VimApi
{
	public class VmFaultToleranceConfigIssue : VmFaultToleranceIssue
	{
		protected string _reason;
		protected string _entityName;
		protected ManagedObjectReference _entity;
		protected VmFaultToleranceConfigIssue_LinkedView _linkedView;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
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
		public VmFaultToleranceConfigIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
