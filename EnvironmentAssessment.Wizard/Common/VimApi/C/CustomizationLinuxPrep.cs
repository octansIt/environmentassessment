namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationLinuxPrep : CustomizationIdentitySettings
	{
		protected CustomizationName _hostName;
		protected string _domain;
		protected string _timeZone;
		protected bool? _hwClockUTC;
		public CustomizationName HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public string Domain
		{
			get
			{
				return this._domain;
			}
			set
			{
				this._domain = value;
			}
		}
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
		public bool? HwClockUTC
		{
			get
			{
				return this._hwClockUTC;
			}
			set
			{
				this._hwClockUTC = value;
			}
		}
	}
}
