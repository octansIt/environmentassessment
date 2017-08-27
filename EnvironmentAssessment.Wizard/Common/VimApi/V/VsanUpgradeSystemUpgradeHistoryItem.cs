using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemUpgradeHistoryItem : DynamicData
	{
		protected DateTime _timestamp;
		protected ManagedObjectReference _host;
		protected string _message;
		protected ManagedObjectReference _task;
		protected VsanUpgradeSystemUpgradeHistoryItem_LinkedView _linkedView;
		public DateTime Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
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
		public VsanUpgradeSystemUpgradeHistoryItem_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
