namespace EnvironmentAssessment.Common.VimApi
{
	public class NoPermission : SecurityError
	{
		protected ManagedObjectReference _object;
		protected string _privilegeId;
		public ManagedObjectReference Object
		{
			get
			{
				return this._object;
			}
			set
			{
				this._object = value;
			}
		}
		public string PrivilegeId
		{
			get
			{
				return this._privilegeId;
			}
			set
			{
				this._privilegeId = value;
			}
		}
	}
}
