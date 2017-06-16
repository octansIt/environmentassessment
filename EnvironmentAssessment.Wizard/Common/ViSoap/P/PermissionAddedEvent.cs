namespace EnvironmentAssessment.Common.VISoap
{
    public class PermissionAddedEvent : PermissionEvent
	{
		protected RoleEventArgument _role;
		protected bool _propagate;
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
		public bool Propagate
		{
			get
			{
				return this._propagate;
			}
			set
			{
				this._propagate = value;
			}
		}
	}
}
