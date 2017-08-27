namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSystemResourceInfo : DynamicData
	{
		protected string _key;
		protected ResourceConfigSpec _config;
		protected HostSystemResourceInfo[] _child;
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
		public ResourceConfigSpec Config
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
		public HostSystemResourceInfo[] Child
		{
			get
			{
				return this._child;
			}
			set
			{
				this._child = value;
			}
		}
	}
}
