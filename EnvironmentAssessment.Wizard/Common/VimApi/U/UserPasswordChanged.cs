namespace EnvironmentAssessment.Common.VimApi
{
	public class UserPasswordChanged : HostEvent
	{
		protected string _userLogin;
		public string UserLogin
		{
			get
			{
				return this._userLogin;
			}
			set
			{
				this._userLogin = value;
			}
		}
	}
}
