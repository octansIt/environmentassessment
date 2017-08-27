namespace EnvironmentAssessment.Common.VimApi
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
