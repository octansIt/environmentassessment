namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasVmSettings : DynamicData
	{
		protected string _restartPriority;
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
