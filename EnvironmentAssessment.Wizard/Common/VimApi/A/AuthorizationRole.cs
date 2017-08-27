namespace EnvironmentAssessment.Common.VimApi
{
	public class AuthorizationRole : DynamicData
	{
		protected int _roleId;
		protected bool _system;
		protected string _name;
		protected Description _info;
		protected string[] _privilege;
		public int RoleId
		{
			get
			{
				return this._roleId;
			}
			set
			{
				this._roleId = value;
			}
		}
		public bool System
		{
			get
			{
				return this._system;
			}
			set
			{
				this._system = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public Description Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
		public string[] Privilege
		{
			get
			{
				return this._privilege;
			}
			set
			{
				this._privilege = value;
			}
		}
	}
}
