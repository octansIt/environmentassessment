namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDateTimeConfig : DynamicData
	{
		protected string _timeZone;
		protected HostNtpConfig _ntpConfig;
		public string TimeZone
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
