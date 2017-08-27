namespace EnvironmentAssessment.Common.VimApi
{
	public class PermissionEvent : AuthorizationEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected string _principal;
		protected bool _group;
		public ManagedEntityEventArgument Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public bool Group
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
