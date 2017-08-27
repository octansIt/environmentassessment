using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterActionHistory : DynamicData
	{
		protected ClusterAction _action;
		protected DateTime _time;
		public ClusterAction Action
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
	}
}
