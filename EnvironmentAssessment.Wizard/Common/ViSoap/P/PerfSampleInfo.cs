using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class PerfSampleInfo : DynamicData
	{
		protected DateTime _timestamp;
		protected int _interval;
		public DateTime Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public int Interval
		{
			get
			{
				return this._interval;
			}
			set
			{
				this._interval = value;
			}
		}
	}
}
