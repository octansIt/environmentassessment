namespace EnvironmentAssessment.Common.VISoap
{
    public class UnsupportedGuest : InvalidVmConfig
	{
		protected string _unsupportedGuestOS;
		public string UnsupportedGuestOS
		{
			get
			{
				return this._unsupportedGuestOS;
			}
			set
			{
				this._unsupportedGuestOS = value;
			}
		}
	}
}
