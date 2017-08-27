namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseSourceUnavailable : NotEnoughLicenses
	{
		protected LicenseSource _licenseSource;
		public LicenseSource LicenseSource
		{
			get
			{
				return this._licenseSource;
			}
			set
			{
				this._licenseSource = value;
			}
		}
	}
}
