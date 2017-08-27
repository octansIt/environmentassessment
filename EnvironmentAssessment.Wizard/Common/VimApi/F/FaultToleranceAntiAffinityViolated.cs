namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceAntiAffinityViolated : MigrationFault
	{
		protected string _hostName;
		protected ManagedObjectReference _host;
		protected FaultToleranceAntiAffinityViolated_LinkedView _linkedView;
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
		public FaultToleranceAntiAffinityViolated_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
