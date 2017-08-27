namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemNetworkPartitionIssue : VsanUpgradeSystemPreflightCheckIssue
	{
		protected VsanUpgradeSystemNetworkPartitionInfo[] _partitions;
		public VsanUpgradeSystemNetworkPartitionInfo[] Partitions
		{
			get
			{
				return this._partitions;
			}
			set
			{
				this._partitions = value;
			}
		}
	}
}
