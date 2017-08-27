namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskFilterSpecByUsername : DynamicData
	{
		protected bool _systemUser;
		protected string[] _userList;
		public bool SystemUser
		{
			get
			{
				return this._systemUser;
			}
			set
			{
				this._systemUser = value;
			}
		}
		public string[] UserList
		{
			get
			{
				return this._userList;
			}
			set
			{
				this._userList = value;
			}
		}
	}
}
