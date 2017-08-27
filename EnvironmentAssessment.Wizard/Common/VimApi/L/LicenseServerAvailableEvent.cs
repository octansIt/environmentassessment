namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseServerAvailableEvent : LicenseEvent
	{
		protected string _licenseServer;
		public string LicenseServer
		{
			get
			{
				return this._licenseServer;
			}
			set
			{
				this._licenseServer = value;
			}
		}
	}
}
