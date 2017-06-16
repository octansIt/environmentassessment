namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmEmailFailedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected string _to;
		protected LocalizedMethodFault _reason;
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
		public LocalizedMethodFault Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
