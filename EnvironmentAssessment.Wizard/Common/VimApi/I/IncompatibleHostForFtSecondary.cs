namespace EnvironmentAssessment.Common.VimApi
{
	public class IncompatibleHostForFtSecondary : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _host;
		protected LocalizedMethodFault[] _error;
		protected IncompatibleHostForFtSecondary_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public LocalizedMethodFault[] Error
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
		public IncompatibleHostForFtSecondary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
