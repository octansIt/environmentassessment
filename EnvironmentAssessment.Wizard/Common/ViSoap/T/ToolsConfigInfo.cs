namespace EnvironmentAssessment.Common.VISoap
{
    public class ToolsConfigInfo : DynamicData
	{
		protected int? _toolsVersion;
		protected bool? _afterPowerOn;
		protected bool? _afterResume;
		protected bool? _beforeGuestStandby;
		protected bool? _beforeGuestShutdown;
		protected bool? _beforeGuestReboot;
		protected string _toolsUpgradePolicy;
		protected string _pendingCustomization;
		protected bool? _syncTimeWithHost;
		protected ToolsConfigInfoToolsLastInstallInfo _lastInstallInfo;
		protected bool? _upgradeRebootPredict;
		public int? ToolsVersion
		{
			get
			{
				return this._toolsVersion;
			}
			set
			{
				this._toolsVersion = value;
			}
		}
		public bool? AfterPowerOn
		{
			get
			{
				return this._afterPowerOn;
			}
			set
			{
				this._afterPowerOn = value;
			}
		}
		public bool? AfterResume
		{
			get
			{
				return this._afterResume;
			}
			set
			{
				this._afterResume = value;
			}
		}
		public bool? BeforeGuestStandby
		{
			get
			{
				return this._beforeGuestStandby;
			}
			set
			{
				this._beforeGuestStandby = value;
			}
		}
		public bool? BeforeGuestShutdown
		{
			get
			{
				return this._beforeGuestShutdown;
			}
			set
			{
				this._beforeGuestShutdown = value;
			}
		}
		public bool? BeforeGuestReboot
		{
			get
			{
				return this._beforeGuestReboot;
			}
			set
			{
				this._beforeGuestReboot = value;
			}
		}
		public string ToolsUpgradePolicy
		{
			get
			{
				return this._toolsUpgradePolicy;
			}
			set
			{
				this._toolsUpgradePolicy = value;
			}
		}
		public string PendingCustomization
		{
			get
			{
				return this._pendingCustomization;
			}
			set
			{
				this._pendingCustomization = value;
			}
		}
		public bool? SyncTimeWithHost
		{
			get
			{
				return this._syncTimeWithHost;
			}
			set
			{
				this._syncTimeWithHost = value;
			}
		}
		public ToolsConfigInfoToolsLastInstallInfo LastInstallInfo
		{
			get
			{
				return this._lastInstallInfo;
			}
			set
			{
				this._lastInstallInfo = value;
			}
		}
		public bool? UpgradeRebootPredict
		{
			get
			{
				return this._upgradeRebootPredict;
			}
			set
			{
				this._upgradeRebootPredict = value;
			}
		}
	}
}
