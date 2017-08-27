namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmEmailCompletedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected string _to;
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
		public string To
		{
			get
			{
				return this._to;
			}
			set
			{
				this._to = value;
			}
		}
	}
}
