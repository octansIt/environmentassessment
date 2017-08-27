using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class EventFilterSpecByTime : DynamicData
	{
		protected DateTime? _beginTime;
		protected DateTime? _endTime;
		public DateTime? BeginTime
		{
			get
			{
				return this._beginTime;
			}
			set
			{
				this._beginTime = value;
			}
		}
		public DateTime? EndTime
		{
			get
			{
				return this._endTime;
			}
			set
			{
				this._endTime = value;
			}
		}
	}
}
