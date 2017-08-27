namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskReasonAlarm : TaskReason
	{
		protected string _alarmName;
		protected ManagedObjectReference _alarm;
		protected string _entityName;
		protected ManagedObjectReference _entity;
		protected TaskReasonAlarm_LinkedView _linkedView;
		public string AlarmName
		{
			get
			{
				return this._alarmName;
			}
			set
			{
				this._alarmName = value;
			}
		}
		public ManagedObjectReference Alarm
		{
			get
			{
				return this._alarm;
			}
			set
			{
				this._alarm = value;
			}
		}
		public string EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				this._entityName = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public TaskReasonAlarm_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
