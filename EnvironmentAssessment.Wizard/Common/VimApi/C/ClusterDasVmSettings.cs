namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasVmSettings : DynamicData
	{
		protected string _restartPriority;
		protected int? _restartPriorityTimeout;
		protected string _isolationResponse;
		protected ClusterVmToolsMonitoringSettings _vmToolsMonitoringSettings;
		protected ClusterVmComponentProtectionSettings _vmComponentProtectionSettings;
		public string RestartPriority
		{
			get
			{
				return this._restartPriority;
			}
			set
			{
				this._restartPriority = value;
			}
		}
		public int? RestartPriorityTimeout
		{
			get
			{
				return this._restartPriorityTimeout;
			}
			set
			{
				this._restartPriorityTimeout = value;
			}
		}
		public string IsolationResponse
		{
			get
			{
				return this._isolationResponse;
			}
			set
			{
				this._isolationResponse = value;
			}
		}
		public ClusterVmToolsMonitoringSettings VmToolsMonitoringSettings
		{
			get
			{
				return this._vmToolsMonitoringSettings;
			}
			set
			{
				this._vmToolsMonitoringSettings = value;
			}
		}
		public ClusterVmComponentProtectionSettings VmComponentProtectionSettings
		{
			get
			{
				return this._vmComponentProtectionSettings;
			}
			set
			{
				this._vmComponentProtectionSettings = value;
			}
		}
	}
}
