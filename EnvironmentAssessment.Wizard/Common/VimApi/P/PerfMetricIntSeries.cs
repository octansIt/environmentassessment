namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfMetricIntSeries : PerfMetricSeries
	{
		protected long[] _value;
		public long[] Value
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
