namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationSysprepFailed : CustomizationFailed
	{
		protected string _sysprepVersion;
		protected string _systemVersion;
		public string SysprepVersion
		{
			get
			{
				return this._sysprepVersion;
			}
			set
			{
				this._sysprepVersion = value;
			}
		}
		public string SystemVersion
		{
			get
			{
				return this._systemVersion;
			}
			set
			{
				this._systemVersion = value;
			}
		}
	}
}
