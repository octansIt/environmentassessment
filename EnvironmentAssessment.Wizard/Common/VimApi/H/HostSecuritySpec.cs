namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSecuritySpec : DynamicData
	{
		protected string _adminPassword;
		protected Permission[] _removePermission;
		protected Permission[] _addPermission;
		public string AdminPassword
		{
			get
			{
				return this._adminPassword;
			}
			set
			{
				this._adminPassword = value;
			}
		}
		public Permission[] RemovePermission
		{
			get
			{
				return this._removePermission;
			}
			set
			{
				this._removePermission = value;
			}
		}
		public Permission[] AddPermission
		{
			get
			{
				return this._addPermission;
			}
			set
			{
				this._addPermission = value;
			}
		}
	}
}
