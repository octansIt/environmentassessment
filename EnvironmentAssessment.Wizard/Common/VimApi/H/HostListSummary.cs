namespace EnvironmentAssessment.Common.VimApi
{
	public class HostListSummary : DynamicData
	{
		protected ManagedObjectReference _host;
		protected HostHardwareSummary _hardware;
		protected HostRuntimeInfo _runtime;
		protected HostConfigSummary _config;
		protected HostListSummaryQuickStats _quickStats;
		protected ManagedEntityStatus _overallStatus;
		protected bool _rebootRequired;
		protected CustomFieldValue[] _customValue;
		protected string _managementServerIp;
		protected string _maxEVCModeKey;
		protected string _currentEVCModeKey;
		protected HostListSummaryGatewaySummary _gateway;
		protected HostListSummary_LinkedView _linkedView;
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
		public HostHardwareSummary Hardware
		{
			get
			{
				return this._hardware;
			}
			set
			{
				this._hardware = value;
			}
		}
		public HostRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
			set
			{
				this._runtime = value;
			}
		}
		public HostConfigSummary Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
		public HostListSummaryQuickStats QuickStats
		{
			get
			{
				return this._quickStats;
			}
			set
			{
				this._quickStats = value;
			}
		}
		public ManagedEntityStatus OverallStatus
		{
			get
			{
				return this._overallStatus;
			}
			set
			{
				this._overallStatus = value;
			}
		}
		public bool RebootRequired
		{
			get
			{
				return this._rebootRequired;
			}
			set
			{
				this._rebootRequired = value;
			}
		}
		public CustomFieldValue[] CustomValue
		{
			get
			{
				return this._customValue;
			}
			set
			{
				this._customValue = value;
			}
		}
		public string ManagementServerIp
		{
			get
			{
				return this._managementServerIp;
			}
			set
			{
				this._managementServerIp = value;
			}
		}
		public string MaxEVCModeKey
		{
			get
			{
				return this._maxEVCModeKey;
			}
			set
			{
				this._maxEVCModeKey = value;
			}
		}
		public string CurrentEVCModeKey
		{
			get
			{
				return this._currentEVCModeKey;
			}
			set
			{
				this._currentEVCModeKey = value;
			}
		}
		public HostListSummaryGatewaySummary Gateway
		{
			get
			{
				return this._gateway;
			}
			set
			{
				this._gateway = value;
			}
		}
		public HostListSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
