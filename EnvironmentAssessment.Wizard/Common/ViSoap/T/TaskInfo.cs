using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class TaskInfo : DynamicData
	{
		protected string _key;
		protected ManagedObjectReference _task;
		protected LocalizableMessage _description;
		protected string _name;
		protected string _descriptionId;
		protected ManagedObjectReference _entity;
		protected string _entityName;
		protected ManagedObjectReference[] _locked;
		protected TaskInfoState _state;
		protected bool _cancelled;
		protected bool _cancelable;
		protected LocalizedMethodFault _error;
		protected object _result;
		protected int? _progress;
		protected TaskReason _reason;
		protected DateTime _queueTime;
		protected DateTime? _startTime;
		protected DateTime? _completeTime;
		protected int _eventChainId;
		protected string _changeTag;
		protected string _parentTaskKey;
		protected string _rootTaskKey;
		protected string _activationId;
		protected TaskInfo_LinkedView _linkedView;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public ManagedObjectReference Task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task = value;
			}
		}
		public LocalizableMessage Description
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
		public string DescriptionId
		{
			get
			{
				return this._descriptionId;
			}
			set
			{
				this._descriptionId = value;
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
		public ManagedObjectReference[] Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				this._locked = value;
			}
		}
		public TaskInfoState State
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
		public bool Cancelled
		{
			get
			{
				return this._cancelled;
			}
			set
			{
				this._cancelled = value;
			}
		}
		public bool Cancelable
		{
			get
			{
				return this._cancelable;
			}
			set
			{
				this._cancelable = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public object Result
		{
			get
			{
				return this._result;
			}
			set
			{
				this._result = value;
			}
		}
		public int? Progress
		{
			get
			{
				return this._progress;
			}
			set
			{
				this._progress = value;
			}
		}
		public TaskReason Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public DateTime QueueTime
		{
			get
			{
				return this._queueTime;
			}
			set
			{
				this._queueTime = value;
			}
		}
		public DateTime? StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				this._startTime = value;
			}
		}
		public DateTime? CompleteTime
		{
			get
			{
				return this._completeTime;
			}
			set
			{
				this._completeTime = value;
			}
		}
		public int EventChainId
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
		public string ChangeTag
		{
			get
			{
				return this._changeTag;
			}
			set
			{
				this._changeTag = value;
			}
		}
		public string ParentTaskKey
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
		public string RootTaskKey
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
		public string ActivationId
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
		public TaskInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
