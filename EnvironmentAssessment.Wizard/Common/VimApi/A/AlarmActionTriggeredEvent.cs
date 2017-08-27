namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmActionTriggeredEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _source;
		protected ManagedEntityEventArgument _entity;
		public ManagedEntityEventArgument Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
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
	}
}
