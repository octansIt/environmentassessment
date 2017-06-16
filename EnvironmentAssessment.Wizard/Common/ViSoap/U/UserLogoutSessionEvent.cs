using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class UserLogoutSessionEvent : SessionEvent
	{
		protected string _ipAddress;
		protected string _userAgent;
		protected long? _callCount;
		protected string _sessionId;
		protected DateTime? _loginTime;
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
		public long? CallCount
		{
			get
			{
				return this._callCount;
			}
			set
			{
				this._callCount = value;
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
		public DateTime? LoginTime
		{
			get
			{
				return this._loginTime;
			}
			set
			{
				this._loginTime = value;
			}
		}
	}
}
