namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskReconfiguredEvent : ScheduledTaskEvent
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
