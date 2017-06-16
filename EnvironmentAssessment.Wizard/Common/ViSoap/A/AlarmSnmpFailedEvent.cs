namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmSnmpFailedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
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
