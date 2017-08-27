namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseNonComplianceEvent : LicenseEvent
	{
		protected string _url;
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
	}
}
