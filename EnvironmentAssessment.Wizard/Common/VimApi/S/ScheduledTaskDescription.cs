namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskDescription : DynamicData
	{
		protected TypeDescription[] _action;
		protected ScheduledTaskDetail[] _schedulerInfo;
		protected ElementDescription[] _state;
		protected ElementDescription[] _dayOfWeek;
		protected ElementDescription[] _weekOfMonth;
		public TypeDescription[] Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
		public ScheduledTaskDetail[] SchedulerInfo
		{
			get
			{
				return this._schedulerInfo;
			}
			set
			{
				this._schedulerInfo = value;
			}
		}
		public ElementDescription[] State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public ElementDescription[] DayOfWeek
		{
			get
			{
				return this._dayOfWeek;
			}
			set
			{
				this._dayOfWeek = value;
			}
		}
		public ElementDescription[] WeekOfMonth
		{
			get
			{
				return this._weekOfMonth;
			}
			set
			{
				this._weekOfMonth = value;
			}
		}
	}
}
