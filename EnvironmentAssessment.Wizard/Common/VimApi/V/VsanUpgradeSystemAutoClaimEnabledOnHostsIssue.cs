namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemAutoClaimEnabledOnHostsIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemAutoClaimEnabledOnHostsIssue_LinkedView _linkedView;
		public ManagedObjectReference[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
		public VsanUpgradeSystemAutoClaimEnabledOnHostsIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
