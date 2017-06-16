namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmScriptFailedEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected string _script;
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
		public string Script
		{
			get
			{
				return this._script;
			}
			set
			{
				this._script = value;
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
