namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemPreflightCheckResult : DynamicData
	{
		protected VsanUpgradeSystemPreflightCheckIssue[] _issues;
		protected VsanHostDiskMapping _diskMappingToRestore;
		public VsanUpgradeSystemPreflightCheckIssue[] Issues
		{
			get
			{
				return this._issues;
			}
			set
			{
				this._issues = value;
			}
		}
		public VsanHostDiskMapping DiskMappingToRestore
		{
			get
			{
				return this._diskMappingToRestore;
			}
			set
			{
				this._diskMappingToRestore = value;
			}
		}
	}
}
