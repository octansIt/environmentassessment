namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemNotEnoughFreeCapacityIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected bool _reducedRedundancyUpgradePossible;
		public bool ReducedRedundancyUpgradePossible
		{
			get
			{
				return this._reducedRedundancyUpgradePossible;
			}
			set
			{
				this._reducedRedundancyUpgradePossible = value;
			}
		}
	}
}
