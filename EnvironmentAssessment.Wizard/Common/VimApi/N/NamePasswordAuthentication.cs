namespace EnvironmentAssessment.Common.VimApi
{
	public class NamePasswordAuthentication : GuestAuthentication
	{
		protected string _username;
		protected string _password;
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
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
	}
}
