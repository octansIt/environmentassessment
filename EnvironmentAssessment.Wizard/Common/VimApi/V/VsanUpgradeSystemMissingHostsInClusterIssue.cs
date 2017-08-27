namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemMissingHostsInClusterIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemMissingHostsInClusterIssue_LinkedView _linkedView;
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
		public VsanUpgradeSystemMissingHostsInClusterIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
