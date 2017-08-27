using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmState : DynamicData
	{
		protected string _key;
		protected ManagedObjectReference _entity;
		protected ManagedObjectReference _alarm;
		protected ManagedEntityStatus _overallStatus;
		protected DateTime _time;
		protected bool? _acknowledged;
		protected string _acknowledgedByUser;
		protected DateTime? _acknowledgedTime;
		protected int? _eventKey;
		protected AlarmState_LinkedView _linkedView;
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
		public ManagedEntityStatus OverallStatus
		{
			get
			{
				return this._overallStatus;
			}
			set
			{
				this._overallStatus = value;
			}
		}
		public DateTime Time
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
		public bool? Acknowledged
		{
			get
			{
				return this._acknowledged;
			}
			set
			{
				this._acknowledged = value;
			}
		}
		public string AcknowledgedByUser
		{
			get
			{
				return this._acknowledgedByUser;
			}
			set
			{
				this._acknowledgedByUser = value;
			}
		}
		public DateTime? AcknowledgedTime
		{
			get
			{
				return this._acknowledgedTime;
			}
			set
			{
				this._acknowledgedTime = value;
			}
		}
		public int? EventKey
		{
			get
			{
				return this._eventKey;
			}
			set
			{
				this._eventKey = value;
			}
		}
		public AlarmState_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
