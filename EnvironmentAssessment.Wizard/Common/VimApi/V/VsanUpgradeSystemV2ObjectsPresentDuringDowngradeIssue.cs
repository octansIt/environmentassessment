namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemV2ObjectsPresentDuringDowngradeIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected string[] _uuids;
		public string[] Uuids
		{
			get
			{
				return this._uuids;
			}
			set
			{
				this._uuids = value;
			}
		}
	}
}
