namespace EnvironmentAssessment.Common.VISoap
{
    public class PerformanceManagerCounterLevelMapping : DynamicData
	{
		protected int _counterId;
		protected int? _aggregateLevel;
		protected int? _perDeviceLevel;
		public int CounterId
		{
			get
			{
				return this._counterId;
			}
			set
			{
				this._counterId = value;
			}
		}
		public int? AggregateLevel
		{
			get
			{
				return this._aggregateLevel;
			}
			set
			{
				this._aggregateLevel = value;
			}
		}
		public int? PerDeviceLevel
		{
			get
			{
				return this._perDeviceLevel;
			}
			set
			{
				this._perDeviceLevel = value;
			}
		}
	}
}
