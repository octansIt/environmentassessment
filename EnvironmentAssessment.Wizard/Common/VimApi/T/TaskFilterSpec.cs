namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskFilterSpec : DynamicData
	{
		protected TaskFilterSpecByEntity _entity;
		protected TaskFilterSpecByTime _time;
		protected TaskFilterSpecByUsername _userName;
		protected string[] _activationId;
		protected TaskInfoState[] _state;
		protected ManagedObjectReference _alarm;
		protected ManagedObjectReference _scheduledTask;
		protected int[] _eventChainId;
		protected string[] _tag;
		protected string[] _parentTaskKey;
		protected string[] _rootTaskKey;
		protected TaskFilterSpec_LinkedView _linkedView;
		public TaskFilterSpecByEntity Entity
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
		public TaskFilterSpecByTime Time
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
		public TaskFilterSpecByUsername UserName
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
		public string[] ActivationId
		{
			get
			{
				return this._activationId;
			}
			set
			{
				this._activationId = value;
			}
		}
		public TaskInfoState[] State
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
		public int[] EventChainId
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
		public string[] ParentTaskKey
		{
			get
			{
				return this._parentTaskKey;
			}
			set
			{
				this._parentTaskKey = value;
			}
		}
		public string[] RootTaskKey
		{
			get
			{
				return this._rootTaskKey;
			}
			set
			{
				this._rootTaskKey = value;
			}
		}
		public TaskFilterSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
