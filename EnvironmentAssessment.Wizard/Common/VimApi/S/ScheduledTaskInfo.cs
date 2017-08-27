using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskInfo : ScheduledTaskSpec
	{
		protected ManagedObjectReference _scheduledTask;
		protected ManagedObjectReference _entity;
		protected DateTime _lastModifiedTime;
		protected string _lastModifiedUser;
		protected DateTime? _nextRunTime;
		protected DateTime? _prevRunTime;
		protected TaskInfoState _state;
		protected LocalizedMethodFault _error;
		protected object _result;
		protected int? _progress;
		protected ManagedObjectReference _activeTask;
		protected ManagedObjectReference _taskObject;
		protected ScheduledTaskInfo_LinkedView _linkedView;
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
		public DateTime LastModifiedTime
		{
			get
			{
				return this._lastModifiedTime;
			}
			set
			{
				this._lastModifiedTime = value;
			}
		}
		public string LastModifiedUser
		{
			get
			{
				return this._lastModifiedUser;
			}
			set
			{
				this._lastModifiedUser = value;
			}
		}
		public DateTime? NextRunTime
		{
			get
			{
				return this._nextRunTime;
			}
			set
			{
				this._nextRunTime = value;
			}
		}
		public DateTime? PrevRunTime
		{
			get
			{
				return this._prevRunTime;
			}
			set
			{
				this._prevRunTime = value;
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
		public ManagedObjectReference ActiveTask
		{
			get
			{
				return this._activeTask;
			}
			set
			{
				this._activeTask = value;
			}
		}
		public ManagedObjectReference TaskObject
		{
			get
			{
				return this._taskObject;
			}
			set
			{
				this._taskObject = value;
			}
		}
		public ScheduledTaskInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
