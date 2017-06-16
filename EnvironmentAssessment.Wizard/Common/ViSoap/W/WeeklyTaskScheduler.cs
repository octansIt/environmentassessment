namespace EnvironmentAssessment.Common.VISoap
{
    public class WeeklyTaskScheduler : DailyTaskScheduler
	{
		protected bool _sunday;
		protected bool _monday;
		protected bool _tuesday;
		protected bool _wednesday;
		protected bool _thursday;
		protected bool _friday;
		protected bool _saturday;
		public bool Sunday
		{
			get
			{
				return this._sunday;
			}
			set
			{
				this._sunday = value;
			}
		}
		public bool Monday
		{
			get
			{
				return this._monday;
			}
			set
			{
				this._monday = value;
			}
		}
		public bool Tuesday
		{
			get
			{
				return this._tuesday;
			}
			set
			{
				this._tuesday = value;
			}
		}
		public bool Wednesday
		{
			get
			{
				return this._wednesday;
			}
			set
			{
				this._wednesday = value;
			}
		}
		public bool Thursday
		{
			get
			{
				return this._thursday;
			}
			set
			{
				this._thursday = value;
			}
		}
		public bool Friday
		{
			get
			{
				return this._friday;
			}
			set
			{
				this._friday = value;
			}
		}
		public bool Saturday
		{
			get
			{
				return this._saturday;
			}
			set
			{
				this._saturday = value;
			}
		}
	}
}
