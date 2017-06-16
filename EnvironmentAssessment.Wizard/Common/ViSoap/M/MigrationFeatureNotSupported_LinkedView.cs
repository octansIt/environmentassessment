namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationFeatureNotSupported_LinkedView
	{
		protected HostSystem _failedHost;
		public HostSystem FailedHost
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
	}
}
