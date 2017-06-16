namespace EnvironmentAssessment.Common.VISoap
{
    public class PerformanceStatisticsDescription : DynamicData
	{
		protected PerfInterval[] _intervals;
		public PerfInterval[] Intervals
		{
			get
			{
				return this._intervals;
			}
			set
			{
				this._intervals = value;
			}
		}
	}
}
