namespace EnvironmentAssessment.Common.VISoap
{
    public class MonthlyByWeekdayTaskScheduler : MonthlyTaskScheduler
	{
		protected WeekOfMonth _offset;
		protected DayOfWeek _weekday;
		public WeekOfMonth Offset
		{
			get
			{
				return this._offset;
			}
			set
			{
				this._offset = value;
			}
		}
		public DayOfWeek Weekday
		{
			get
			{
				return this._weekday;
			}
			set
			{
				this._weekday = value;
			}
		}
	}
}
