namespace EnvironmentAssessment.Common.VimApi
{
	public class DatabaseSizeParam : DynamicData
	{
		protected InventoryDescription _inventoryDesc;
		protected PerformanceStatisticsDescription _perfStatsDesc;
		public InventoryDescription InventoryDesc
		{
			get
			{
				return this._inventoryDesc;
			}
			set
			{
				this._inventoryDesc = value;
			}
		}
		public PerformanceStatisticsDescription PerfStatsDesc
		{
			get
			{
				return this._perfStatsDesc;
			}
			set
			{
				this._perfStatsDesc = value;
			}
		}
	}
}
