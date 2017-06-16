namespace EnvironmentAssessment.Common.VISoap
{
    public class RoleUpdatedEvent : RoleEvent
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
