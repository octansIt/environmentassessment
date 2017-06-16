namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmAcknowledgedEvent : AlarmEvent
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
