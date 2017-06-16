namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskSpec : DynamicData
	{
		protected string _name;
		protected string _description;
		protected bool _enabled;
		protected TaskScheduler _scheduler;
		protected Action _action;
		protected string _notification;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public TaskScheduler Scheduler
		{
			get
			{
				return this._scheduler;
			}
			set
			{
				this._scheduler = value;
			}
		}
		public Action Action
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
		public string Notification
		{
			get
			{
				return this._notification;
			}
			set
			{
				this._notification = value;
			}
		}
	}
}
