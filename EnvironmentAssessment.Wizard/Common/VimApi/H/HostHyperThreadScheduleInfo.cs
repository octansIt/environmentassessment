namespace EnvironmentAssessment.Common.VimApi
{
	public class HostHyperThreadScheduleInfo : DynamicData
	{
		protected bool _available;
		protected bool _active;
		protected bool _config;
		public bool Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		public bool Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
	}
}
