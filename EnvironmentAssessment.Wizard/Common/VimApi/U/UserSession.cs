using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class UserSession : DynamicData
	{
		protected string _key;
		protected string _userName;
		protected string _fullName;
		protected DateTime _loginTime;
		protected DateTime _lastActiveTime;
		protected string _locale;
		protected string _messageLocale;
		protected bool _extensionSession;
		protected string _ipAddress;
		protected string _userAgent;
		protected long _callCount;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		public DateTime LoginTime
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
		public DateTime LastActiveTime
		{
			get
			{
				return this._lastActiveTime;
			}
			set
			{
				this._lastActiveTime = value;
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
		public string MessageLocale
		{
			get
			{
				return this._messageLocale;
			}
			set
			{
				this._messageLocale = value;
			}
		}
		public bool ExtensionSession
		{
			get
			{
				return this._extensionSession;
			}
			set
			{
				this._extensionSession = value;
			}
		}
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
		public long CallCount
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
	}
}
