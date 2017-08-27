namespace EnvironmentAssessment.Common.VimApi
{
	public class ToolsConfigInfo : DynamicData
	{
		protected int? _toolsVersion;
		protected string _toolsInstallType;
		protected bool? _afterPowerOn;
		protected bool? _afterResume;
		protected bool? _beforeGuestStandby;
		protected bool? _beforeGuestShutdown;
		protected bool? _beforeGuestReboot;
		protected string _toolsUpgradePolicy;
		protected string _pendingCustomization;
		protected CryptoKeyId _customizationKeyId;
		protected bool? _syncTimeWithHost;
		protected ToolsConfigInfoToolsLastInstallInfo _lastInstallInfo;
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
		public string ToolsInstallType
		{
			get
			{
				return this._toolsInstallType;
			}
			set
			{
				this._toolsInstallType = value;
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
		public CryptoKeyId CustomizationKeyId
		{
			get
			{
				return this._customizationKeyId;
			}
			set
			{
				this._customizationKeyId = value;
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
	}
}
