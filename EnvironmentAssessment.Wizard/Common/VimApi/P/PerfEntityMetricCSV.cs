namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfEntityMetricCSV : PerfEntityMetricBase
	{
		protected string _sampleInfoCSV;
		protected PerfMetricSeriesCSV[] _value;
		public string SampleInfoCSV
		{
			get
			{
				return this._sampleInfoCSV;
			}
			set
			{
				this._sampleInfoCSV = value;
			}
		}
		public PerfMetricSeriesCSV[] Value
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
