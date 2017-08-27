namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSFeatureCapability : DynamicData
	{
		protected bool _networkResourceManagementSupported;
		protected bool _vmDirectPathGen2Supported;
		protected string[] _nicTeamingPolicy;
		protected int? _networkResourcePoolHighShareValue;
		protected DVSNetworkResourceManagementCapability _networkResourceManagementCapability;
		protected DVSHealthCheckCapability _healthCheckCapability;
		protected DVSRollbackCapability _rollbackCapability;
		protected DVSBackupRestoreCapability _backupRestoreCapability;
		protected bool? _networkFilterSupported;
		public bool NetworkResourceManagementSupported
		{
			get
			{
				return this._networkResourceManagementSupported;
			}
			set
			{
				this._networkResourceManagementSupported = value;
			}
		}
		public bool VmDirectPathGen2Supported
		{
			get
			{
				return this._vmDirectPathGen2Supported;
			}
			set
			{
				this._vmDirectPathGen2Supported = value;
			}
		}
		public string[] NicTeamingPolicy
		{
			get
			{
				return this._nicTeamingPolicy;
			}
			set
			{
				this._nicTeamingPolicy = value;
			}
		}
		public int? NetworkResourcePoolHighShareValue
		{
			get
			{
				return this._networkResourcePoolHighShareValue;
			}
			set
			{
				this._networkResourcePoolHighShareValue = value;
			}
		}
		public DVSNetworkResourceManagementCapability NetworkResourceManagementCapability
		{
			get
			{
				return this._networkResourceManagementCapability;
			}
			set
			{
				this._networkResourceManagementCapability = value;
			}
		}
		public DVSHealthCheckCapability HealthCheckCapability
		{
			get
			{
				return this._healthCheckCapability;
			}
			set
			{
				this._healthCheckCapability = value;
			}
		}
		public DVSRollbackCapability RollbackCapability
		{
			get
			{
				return this._rollbackCapability;
			}
			set
			{
				this._rollbackCapability = value;
			}
		}
		public DVSBackupRestoreCapability BackupRestoreCapability
		{
			get
			{
				return this._backupRestoreCapability;
			}
			set
			{
				this._backupRestoreCapability = value;
			}
		}
		public bool? NetworkFilterSupported
		{
			get
			{
				return this._networkFilterSupported;
			}
			set
			{
				this._networkFilterSupported = value;
			}
		}
	}
}
