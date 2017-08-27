namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemWrongEsxVersionIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected ManagedObjectReference[] _hosts;
		protected VsanUpgradeSystemWrongEsxVersionIssue_LinkedView _linkedView;
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
		public VsanUpgradeSystemWrongEsxVersionIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
