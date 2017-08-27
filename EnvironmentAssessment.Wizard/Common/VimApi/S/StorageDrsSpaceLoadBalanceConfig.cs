namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsSpaceLoadBalanceConfig : DynamicData
	{
		protected string _spaceThresholdMode;
		protected int? _spaceUtilizationThreshold;
		protected int? _freeSpaceThresholdGB;
		protected int? _minSpaceUtilizationDifference;
		public string SpaceThresholdMode
		{
			get
			{
				return this._spaceThresholdMode;
			}
			set
			{
				this._spaceThresholdMode = value;
			}
		}
		public int? SpaceUtilizationThreshold
		{
			get
			{
				return this._spaceUtilizationThreshold;
			}
			set
			{
				this._spaceUtilizationThreshold = value;
			}
		}
		public int? FreeSpaceThresholdGB
		{
			get
			{
				return this._freeSpaceThresholdGB;
			}
			set
			{
				this._freeSpaceThresholdGB = value;
			}
		}
		public int? MinSpaceUtilizationDifference
		{
			get
			{
				return this._minSpaceUtilizationDifference;
			}
			set
			{
				this._minSpaceUtilizationDifference = value;
			}
		}
	}
}
