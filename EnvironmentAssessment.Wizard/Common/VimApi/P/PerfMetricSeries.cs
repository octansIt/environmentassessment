namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfMetricSeries : DynamicData
	{
		protected PerfMetricId _id;
		public PerfMetricId Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
	}
}
