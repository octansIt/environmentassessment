namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmClearedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _source;
		protected ManagedEntityEventArgument _entity;
		protected string _from;
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
	}
}
