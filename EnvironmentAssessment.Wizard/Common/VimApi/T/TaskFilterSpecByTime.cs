using System;using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskFilterSpecByTime : DynamicData
	{
		protected TaskFilterSpecTimeOption _timeType;
		protected DateTime? _beginTime;
		protected DateTime? _endTime;
		public TaskFilterSpecTimeOption TimeType
		{
			get
			{
				return this._timeType;
			}
			set
			{
				this._timeType = value;
			}
		}
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
