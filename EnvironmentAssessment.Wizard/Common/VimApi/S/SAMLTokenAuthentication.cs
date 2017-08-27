namespace EnvironmentAssessment.Common.VimApi
{
	public class SAMLTokenAuthentication : GuestAuthentication
	{
		protected string _token;
		protected string _username;
		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				this._token = value;
			}
		}
		public string Username
		{
			get
			{
				return this._username;
			}
			set
			{
				this._username = value;
			}
		}
	}
}
