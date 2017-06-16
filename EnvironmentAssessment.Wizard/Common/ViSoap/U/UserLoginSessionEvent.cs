namespace EnvironmentAssessment.Common.VISoap
{
    public class UserLoginSessionEvent : SessionEvent
	{
		protected string _ipAddress;
		protected string _userAgent;
		protected string _locale;
		protected string _sessionId;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public string UserAgent
		{
			get
			{
				return this._userAgent;
			}
			set
			{
				this._userAgent = value;
			}
		}
		public string Locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				this._locale = value;
			}
		}
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
	}
}
