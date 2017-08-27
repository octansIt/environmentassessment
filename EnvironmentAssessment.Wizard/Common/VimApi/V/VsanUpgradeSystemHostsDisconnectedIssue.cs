namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemHostsDisconnectedIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemHostsDisconnectedIssue_LinkedView _linkedView;
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
		public VsanUpgradeSystemHostsDisconnectedIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
