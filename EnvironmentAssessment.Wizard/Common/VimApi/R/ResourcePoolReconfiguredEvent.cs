namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolReconfiguredEvent : ResourcePoolEvent
	{
		protected ChangesInfoEventArgument _configChanges;
		public ChangesInfoEventArgument ConfigChanges
		{
			get
			{
				return this._configChanges;
			}
			set
			{
				this._configChanges = value;
			}
		}
	}
}
