namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledHardwareUpgradeInfo : DynamicData
	{
		protected string _upgradePolicy;
		protected string _versionKey;
		protected string _scheduledHardwareUpgradeStatus;
		protected LocalizedMethodFault _fault;
		public string UpgradePolicy
		{
			get
			{
				return this._upgradePolicy;
			}
			set
			{
				this._upgradePolicy = value;
			}
		}
		public string VersionKey
		{
			get
			{
				return this._versionKey;
			}
			set
			{
				this._versionKey = value;
			}
		}
		public string ScheduledHardwareUpgradeStatus
		{
			get
			{
				return this._scheduledHardwareUpgradeStatus;
			}
			set
			{
				this._scheduledHardwareUpgradeStatus = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
