namespace EnvironmentAssessment.Common.VimApi
{
	public class RoleUpdatedEvent : RoleEvent
	{
		protected string[] _privilegeList;
		protected string _prevRoleName;
		protected string[] _privilegesAdded;
		protected string[] _privilegesRemoved;
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
		public string PrevRoleName
		{
			get
			{
				return this._prevRoleName;
			}
			set
			{
				this._prevRoleName = value;
			}
		}
		public string[] PrivilegesAdded
		{
			get
			{
				return this._privilegesAdded;
			}
			set
			{
				this._privilegesAdded = value;
			}
		}
		public string[] PrivilegesRemoved
		{
			get
			{
				return this._privilegesRemoved;
			}
			set
			{
				this._privilegesRemoved = value;
			}
		}
	}
}
