namespace EnvironmentAssessment.Common.VimApi
{
	public class AuthorizationDescription : DynamicData
	{
		protected ElementDescription[] _privilege;
		protected ElementDescription[] _privilegeGroup;
		public ElementDescription[] Privilege
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
		public ElementDescription[] PrivilegeGroup
		{
			get
			{
				return this._privilegeGroup;
			}
			set
			{
				this._privilegeGroup = value;
			}
		}
	}
}
