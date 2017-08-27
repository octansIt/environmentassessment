namespace EnvironmentAssessment.Common.VimApi
{
    public class DVSDynamicArpInspectionConfig : InheritablePolicy
	{
		protected BoolPolicy _dynamicArpInspectionEnabled;
		protected IntPolicy _arpRateLimit;
		protected IntPolicy _errRateLimit;
		protected IntPolicy _errRateLimitPeriod;
		public BoolPolicy DynamicArpInspectionEnabled
		{
			get
			{
				return this._dynamicArpInspectionEnabled;
			}
			set
			{
				this._dynamicArpInspectionEnabled = value;
			}
		}
		public IntPolicy ArpRateLimit
		{
			get
			{
				return this._arpRateLimit;
			}
			set
			{
				this._arpRateLimit = value;
			}
		}
		public IntPolicy ErrRateLimit
		{
			get
			{
				return this._errRateLimit;
			}
			set
			{
				this._errRateLimit = value;
			}
		}
		public IntPolicy ErrRateLimitPeriod
		{
			get
			{
				return this._errRateLimitPeriod;
			}
			set
			{
				this._errRateLimitPeriod = value;
			}
		}
	}
}
