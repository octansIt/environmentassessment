namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemUpgradeHistoryDiskGroupOp : VsanUpgradeSystemUpgradeHistoryItem
	{
		protected string _operation;
		protected VsanHostDiskMapping _diskMapping;
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
		public VsanHostDiskMapping DiskMapping
		{
			get
			{
				return this._diskMapping;
			}
			set
			{
				this._diskMapping = value;
			}
		}
		public new VsanUpgradeSystemUpgradeHistoryDiskGroupOp_LinkedView LinkedView
		{
			get
			{
				return (VsanUpgradeSystemUpgradeHistoryDiskGroupOp_LinkedView)this._linkedView;
			}
		}
	}
}
