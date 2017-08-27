namespace EnvironmentAssessment.Common.VimApi
{
	public class PermissionUpdatedEvent : PermissionEvent
	{
		protected RoleEventArgument _role;
		protected bool _propagate;
		protected RoleEventArgument _prevRole;
		protected bool? _prevPropagate;
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
		public RoleEventArgument PrevRole
		{
			get
			{
				return this._prevRole;
			}
			set
			{
				this._prevRole = value;
			}
		}
		public bool? PrevPropagate
		{
			get
			{
				return this._prevPropagate;
			}
			set
			{
				this._prevPropagate = value;
			}
		}
	}
}
