namespace EnvironmentAssessment.Common.VISoap
{
    public class PerfMetricSeriesCSV : PerfMetricSeries
	{
		protected string _value;
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
