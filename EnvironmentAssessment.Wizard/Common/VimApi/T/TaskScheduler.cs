using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskScheduler : DynamicData
	{
		protected DateTime? _activeTime;
		protected DateTime? _expireTime;
		public DateTime? ActiveTime
		{
			get
			{
				return this._activeTime;
			}
			set
			{
				this._activeTime = value;
			}
		}
		public DateTime? ExpireTime
		{
			get
			{
				return this._expireTime;
			}
			set
			{
				this._expireTime = value;
			}
		}
	}
}
