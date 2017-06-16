using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class AlarmInfo : AlarmSpec
	{
		protected string _key;
		protected ManagedObjectReference _alarm;
		protected ManagedObjectReference _entity;
		protected DateTime _lastModifiedTime;
		protected string _lastModifiedUser;
		protected int _creationEventId;
		protected AlarmInfo_LinkedView _linkedView;
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
		public int CreationEventId
		{
			get
			{
				return this._creationEventId;
			}
			set
			{
				this._creationEventId = value;
			}
		}
		public AlarmInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
