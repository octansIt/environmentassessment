namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSHealthCheckConfig : DynamicData
	{
		protected bool? _enable;
		protected int? _interval;
		public bool? Enable
		{
			get
			{
				return this._enable;
			}
			set
			{
				this._enable = value;
			}
		}
		public int? Interval
		{
			get
			{
				return this._interval;
			}
			set
			{
				this._interval = value;
			}
		}
	}
}
