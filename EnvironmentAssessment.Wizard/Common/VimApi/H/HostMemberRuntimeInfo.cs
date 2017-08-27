namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMemberRuntimeInfo : DynamicData
	{
		protected ManagedObjectReference _host;
		protected string _status;
		protected string _statusDetail;
		protected HostMemberHealthCheckResult[] _healthCheckResult;
		protected HostMemberRuntimeInfo_LinkedView _linkedView;
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
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string StatusDetail
		{
			get
			{
				return this._statusDetail;
			}
			set
			{
				this._statusDetail = value;
			}
		}
		public HostMemberHealthCheckResult[] HealthCheckResult
		{
			get
			{
				return this._healthCheckResult;
			}
			set
			{
				this._healthCheckResult = value;
			}
		}
		public HostMemberRuntimeInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
