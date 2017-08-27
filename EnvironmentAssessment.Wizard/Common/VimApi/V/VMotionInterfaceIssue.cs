namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionInterfaceIssue : MigrationFault
	{
		protected bool _atSourceHost;
		protected string _failedHost;
		protected ManagedObjectReference _failedHostEntity;
		protected VMotionInterfaceIssue_LinkedView _linkedView;
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
		public string FailedHost
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
		public ManagedObjectReference FailedHostEntity
		{
			get
			{
				return this._failedHostEntity;
			}
			set
			{
				this._failedHostEntity = value;
			}
		}
		public VMotionInterfaceIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
