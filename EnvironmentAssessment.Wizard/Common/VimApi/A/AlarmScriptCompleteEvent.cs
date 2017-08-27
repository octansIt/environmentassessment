namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmScriptCompleteEvent : AlarmEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected string _script;
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
	}
}
