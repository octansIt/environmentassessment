namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolSummary : DynamicData
	{
		protected string _name;
		protected ResourceConfigSpec _config;
		protected ResourcePoolRuntimeInfo _runtime;
		protected ResourcePoolQuickStats _quickStats;
		protected int? _configuredMemoryMB;
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
		public ResourcePoolRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
			set
			{
				this._runtime = value;
			}
		}
		public ResourcePoolQuickStats QuickStats
		{
			get
			{
				return this._quickStats;
			}
			set
			{
				this._quickStats = value;
			}
		}
		public int? ConfiguredMemoryMB
		{
			get
			{
				return this._configuredMemoryMB;
			}
			set
			{
				this._configuredMemoryMB = value;
			}
		}
	}
}
