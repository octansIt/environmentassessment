namespace EnvironmentAssessment.Common.VimApi
{
	public class SSPIAuthentication : GuestAuthentication
	{
		protected string _sspiToken;
		public string SspiToken
		{
			get
			{
				return this._sspiToken;
			}
			set
			{
				this._sspiToken = value;
			}
		}
	}
}
