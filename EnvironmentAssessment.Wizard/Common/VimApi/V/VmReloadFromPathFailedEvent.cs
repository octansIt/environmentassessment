namespace EnvironmentAssessment.Common.VimApi
{
	public class VmReloadFromPathFailedEvent : VmEvent
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
