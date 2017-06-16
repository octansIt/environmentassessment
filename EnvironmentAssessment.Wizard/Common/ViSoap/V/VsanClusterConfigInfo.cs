namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanClusterConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected VsanClusterConfigInfoHostDefaultInfo _defaultConfig;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public VsanClusterConfigInfoHostDefaultInfo DefaultConfig
		{
			get
			{
				return this._defaultConfig;
			}
			set
			{
				this._defaultConfig = value;
			}
		}
	}
}
