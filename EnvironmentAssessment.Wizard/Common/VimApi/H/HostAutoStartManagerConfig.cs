namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAutoStartManagerConfig : DynamicData
	{
		protected AutoStartDefaults _defaults;
		protected AutoStartPowerInfo[] _powerInfo;
		public AutoStartDefaults Defaults
		{
			get
			{
				return this._defaults;
			}
			set
			{
				this._defaults = value;
			}
		}
		public AutoStartPowerInfo[] PowerInfo
		{
			get
			{
				return this._powerInfo;
			}
			set
			{
				this._powerInfo = value;
			}
		}
	}
}
