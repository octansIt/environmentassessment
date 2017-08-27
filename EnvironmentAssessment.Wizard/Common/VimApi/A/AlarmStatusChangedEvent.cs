namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmStatusChangedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _source;
		protected ManagedEntityEventArgument _entity;
		protected string _from;
		protected string _to;
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
		public string From
		{
			get
			{
				return this._from;
			}
			set
			{
				this._from = value;
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
