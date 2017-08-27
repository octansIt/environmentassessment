namespace EnvironmentAssessment.Common.VimApi
{
	public class RoleEventArgument : EventArgument
	{
		protected int _roleId;
		protected string _name;
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
	}
}
