namespace EnvironmentAssessment.Common.VimApi
{
	public class LocalLicenseSource : LicenseSource
	{
		protected string _licenseKeys;
		public string LicenseKeys
		{
			get
			{
				return this._licenseKeys;
			}
			set
			{
				this._licenseKeys = value;
			}
		}
	}
}
