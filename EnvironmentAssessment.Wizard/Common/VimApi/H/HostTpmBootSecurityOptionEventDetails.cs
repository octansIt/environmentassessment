namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmBootSecurityOptionEventDetails : HostTpmEventDetails
	{
		protected string _bootSecurityOption;
		public string BootSecurityOption
		{
			get
			{
				return this._bootSecurityOption;
			}
			set
			{
				this._bootSecurityOption = value;
			}
		}
	}
}
