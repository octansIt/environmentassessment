namespace EnvironmentAssessment.Common.VimApi
{
	public class RoleEvent : AuthorizationEvent
	{
		protected RoleEventArgument _role;
		public RoleEventArgument Role
		{
			get
			{
				return this._role;
			}
			set
			{
				this._role = value;
			}
		}
	}
}
