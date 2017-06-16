namespace EnvironmentAssessment.Common.VISoap
{
    public class EventFilterSpec : DynamicData
	{
		protected EventFilterSpecByEntity _entity;
		protected EventFilterSpecByTime _time;
		protected EventFilterSpecByUsername _userName;
		protected int? _eventChainId;
		protected ManagedObjectReference _alarm;
		protected ManagedObjectReference _scheduledTask;
		protected bool? _disableFullMessage;
		protected string[] _category;
		protected string[] _type;
		protected string[] _tag;
		protected string[] _eventTypeId;
		protected EventFilterSpec_LinkedView _linkedView;
		public EventFilterSpecByEntity Entity
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
		public EventFilterSpecByTime Time
		{
			get
			{
				return this._time;
			}
			set
			{
				this._time = value;
			}
		}
		public EventFilterSpecByUsername UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public int? EventChainId
		{
			get
			{
				return this._eventChainId;
			}
			set
			{
				this._eventChainId = value;
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
		public ManagedObjectReference ScheduledTask
		{
			get
			{
				return this._scheduledTask;
			}
			set
			{
				this._scheduledTask = value;
			}
		}
		public bool? DisableFullMessage
		{
			get
			{
				return this._disableFullMessage;
			}
			set
			{
				this._disableFullMessage = value;
			}
		}
		public string[] Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		public string[] Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string[] Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}
		public string[] EventTypeId
		{
			get
			{
				return this._eventTypeId;
			}
			set
			{
				this._eventTypeId = value;
			}
		}
		public EventFilterSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
