namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDateTimeInfo : DynamicData
	{
		protected HostDateTimeSystemTimeZone _timeZone;
		protected HostNtpConfig _ntpConfig;
		public HostDateTimeSystemTimeZone TimeZone
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
		public HostNtpConfig NtpConfig
		{
			get
			{
				return this._ntpConfig;
			}
			set
			{
				this._ntpConfig = value;
			}
		}
	}
}
