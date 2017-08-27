namespace EnvironmentAssessment.Common.VimApi
{
	public class VmReloadFromPathEvent : VmEvent
	{
		protected string _configPath;
		public string ConfigPath
		{
			get
			{
				return this._configPath;
			}
			set
			{
				this._configPath = value;
			}
		}
	}
}
