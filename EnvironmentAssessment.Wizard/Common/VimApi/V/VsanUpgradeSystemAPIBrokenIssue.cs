namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemAPIBrokenIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemAPIBrokenIssue_LinkedView _linkedView;
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
		public VsanUpgradeSystemAPIBrokenIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
