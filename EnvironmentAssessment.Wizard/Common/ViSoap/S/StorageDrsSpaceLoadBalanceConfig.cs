namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageDrsSpaceLoadBalanceConfig : DynamicData
	{
		protected string _spaceLoadBalanceAutomationMode;
		protected string _spaceThresholdMode;
		protected int? _spaceUtilizationThreshold;
		protected int? _freeSpaceThresholdGB;
		protected int? _minSpaceUtilizationDifference;
		public string SpaceLoadBalanceAutomationMode
		{
			get
			{
				return this._spaceLoadBalanceAutomationMode;
			}
			set
			{
				this._spaceLoadBalanceAutomationMode = value;
			}
		}
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
