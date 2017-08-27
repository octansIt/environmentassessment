namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationGuiUnattended : DynamicData
	{
		protected CustomizationPassword _password;
		protected int _timeZone;
		protected bool _autoLogon;
		protected int _autoLogonCount;
		public CustomizationPassword Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		public int TimeZone
		{
			get
			{
				return this._timeZone;
			}
			set
			{
				this._timeZone = value;
			}
		}
		public bool AutoLogon
		{
			get
			{
				return this._autoLogon;
			}
			set
			{
				this._autoLogon = value;
			}
		}
		public int AutoLogonCount
		{
			get
			{
				return this._autoLogonCount;
			}
			set
			{
				this._autoLogonCount = value;
			}
		}
	}
}
