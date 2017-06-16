namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterVmToolsMonitoringSettings : DynamicData
	{
		protected bool? _enabled;
		protected string _vmMonitoring;
		protected bool? _clusterSettings;
		protected int? _failureInterval;
		protected int? _minUpTime;
		protected int? _maxFailures;
		protected int? _maxFailureWindow;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public string VmMonitoring
		{
			get
			{
				return this._vmMonitoring;
			}
			set
			{
				this._vmMonitoring = value;
			}
		}
		public bool? ClusterSettings
		{
			get
			{
				return this._clusterSettings;
			}
			set
			{
				this._clusterSettings = value;
			}
		}
		public int? FailureInterval
		{
			get
			{
				return this._failureInterval;
			}
			set
			{
				this._failureInterval = value;
			}
		}
		public int? MinUpTime
		{
			get
			{
				return this._minUpTime;
			}
			set
			{
				this._minUpTime = value;
			}
		}
		public int? MaxFailures
		{
			get
			{
				return this._maxFailures;
			}
			set
			{
				this._maxFailures = value;
			}
		}
		public int? MaxFailureWindow
		{
			get
			{
				return this._maxFailureWindow;
			}
			set
			{
				this._maxFailureWindow = value;
			}
		}
	}
}
