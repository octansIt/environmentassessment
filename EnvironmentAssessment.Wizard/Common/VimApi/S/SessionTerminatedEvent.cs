namespace EnvironmentAssessment.Common.VimApi
{
	public class SessionTerminatedEvent : SessionEvent
	{
		protected string _sessionId;
		protected string _terminatedUsername;
		public string SessionId
		{
			get
			{
				return this._sessionId;
			}
			set
			{
				this._sessionId = value;
			}
		}
		public string TerminatedUsername
		{
			get
			{
				return this._terminatedUsername;
			}
			set
			{
				this._terminatedUsername = value;
			}
		}
	}
}
