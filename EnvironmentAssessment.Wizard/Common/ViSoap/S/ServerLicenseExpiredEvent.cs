namespace EnvironmentAssessment.Common.VISoap
{
    public class ServerLicenseExpiredEvent : LicenseEvent
	{
		protected string _product;
		public string Product
		{
			get
			{
				return this._product;
			}
			set
			{
				this._product = value;
			}
		}
	}
}
