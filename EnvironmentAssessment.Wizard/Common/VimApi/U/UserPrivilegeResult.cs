namespace EnvironmentAssessment.Common.VimApi
{
	public class UserPrivilegeResult : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected string[] _privileges;
		protected UserPrivilegeResult_LinkedView _linkedView;
		public ManagedObjectReference Entity
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
		public string[] Privileges
		{
			get
			{
				return this._privileges;
			}
			set
			{
				this._privileges = value;
			}
		}
		public UserPrivilegeResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
