namespace EnvironmentAssessment.Common.VimApi
{
	public class RoleAddedEvent : RoleEvent
	{
		protected string[] _privilegeList;
		public string[] PrivilegeList
		{
			get
			{
				return this._privilegeList;
			}
			set
			{
				this._privilegeList = value;
			}
		}
	}
}
