namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseExpired : NotEnoughLicenses
	{
		protected string _licenseKey;
		public string LicenseKey
		{
			get
			{
				return this._licenseKey;
			}
			set
			{
				this._licenseKey = value;
			}
		}
	}
}
