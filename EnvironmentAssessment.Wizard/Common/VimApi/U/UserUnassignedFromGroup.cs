namespace EnvironmentAssessment.Common.VimApi
{
	public class UserUnassignedFromGroup : HostEvent
	{
		protected string _userLogin;
		protected string _group;
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
		public string Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
	}
}
