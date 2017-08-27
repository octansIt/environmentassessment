namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDeploymentInfo : DynamicData
	{
		protected bool? _bootedFromStatelessCache;
		public bool? BootedFromStatelessCache
		{
			get
			{
				return this._bootedFromStatelessCache;
			}
			set
			{
				this._bootedFromStatelessCache = value;
			}
		}
	}
}
