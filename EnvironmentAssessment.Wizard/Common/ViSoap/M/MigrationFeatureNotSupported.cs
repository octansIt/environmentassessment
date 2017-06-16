namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationFeatureNotSupported : MigrationFault
	{
		protected bool _atSourceHost;
		protected string _failedHostName;
		protected ManagedObjectReference _failedHost;
		protected MigrationFeatureNotSupported_LinkedView _linkedView;
		public bool AtSourceHost
		{
			get
			{
				return this._atSourceHost;
			}
			set
			{
				this._atSourceHost = value;
			}
		}
		public string FailedHostName
		{
			get
			{
				return this._failedHostName;
			}
			set
			{
				this._failedHostName = value;
			}
		}
		public ManagedObjectReference FailedHost
		{
			get
			{
				return this._failedHost;
			}
			set
			{
				this._failedHost = value;
			}
		}
		public MigrationFeatureNotSupported_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
