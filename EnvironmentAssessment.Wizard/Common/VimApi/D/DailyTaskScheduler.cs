using System;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DailyTaskScheduler : HourlyTaskScheduler
	{
		protected int _hour;
		public int Hour
		{
			get
			{
				return this._hour;
			}
			set
			{
				this._hour = value;
			}
		}
	}
}
