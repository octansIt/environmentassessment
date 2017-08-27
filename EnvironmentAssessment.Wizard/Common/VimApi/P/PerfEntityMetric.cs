namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfEntityMetric : PerfEntityMetricBase
	{
		protected PerfSampleInfo[] _sampleInfo;
		protected PerfMetricSeries[] _value;
		public PerfSampleInfo[] SampleInfo
		{
			get
			{
				return this._sampleInfo;
			}
			set
			{
				this._sampleInfo = value;
			}
		}
		public PerfMetricSeries[] Value
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
