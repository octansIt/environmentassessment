namespace EnvironmentAssessment.Common.VimApi
{
	public class PerformanceDescription : DynamicData
	{
		protected ElementDescription[] _counterType;
		protected ElementDescription[] _statsType;
		public ElementDescription[] CounterType
		{
			get
			{
				return this._counterType;
			}
			set
			{
				this._counterType = value;
			}
		}
		public ElementDescription[] StatsType
		{
			get
			{
				return this._statsType;
			}
			set
			{
				this._statsType = value;
			}
		}
	}
}
