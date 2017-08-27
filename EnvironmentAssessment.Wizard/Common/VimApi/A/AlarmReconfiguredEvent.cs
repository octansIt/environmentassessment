namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmReconfiguredEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected ChangesInfoEventArgument _configChanges;
		public ManagedEntityEventArgument Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
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
