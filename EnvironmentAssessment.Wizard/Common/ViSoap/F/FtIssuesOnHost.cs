namespace EnvironmentAssessment.Common.VISoap
{
    public class FtIssuesOnHost : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _host;
		protected string _hostName;
		protected LocalizedMethodFault[] _errors;
		protected FtIssuesOnHost_LinkedView _linkedView;
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
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public LocalizedMethodFault[] Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
		public FtIssuesOnHost_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
