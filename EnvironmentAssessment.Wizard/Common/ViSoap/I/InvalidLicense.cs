namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidLicense : VimFault
	{
		protected string _licenseContent;
		public string LicenseContent
		{
			get
			{
				return this._licenseContent;
			}
			set
			{
				this._licenseContent = value;
			}
		}
	}
}
