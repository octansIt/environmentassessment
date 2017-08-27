namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemUpgradeHistoryPreflightFail : VsanUpgradeSystemUpgradeHistoryItem
	{
		protected VsanUpgradeSystemPreflightCheckResult _preflightResult;
		public VsanUpgradeSystemPreflightCheckResult PreflightResult
		{
			get
			{
				return this._preflightResult;
			}
			set
			{
				this._preflightResult = value;
			}
		}
		public new VsanUpgradeSystemUpgradeHistoryPreflightFail_LinkedView LinkedView
		{
			get
			{
				return (VsanUpgradeSystemUpgradeHistoryPreflightFail_LinkedView)this._linkedView;
			}
		}
	}
}
