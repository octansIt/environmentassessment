namespace EnvironmentAssessment.Common.VimApi
{
	public class AuthorizationPrivilege : DynamicData
	{
		protected string _privId;
		protected bool _onParent;
		protected string _name;
		protected string _privGroupName;
		public string PrivId
		{
			get
			{
				return this._privId;
			}
			set
			{
				this._privId = value;
			}
		}
		public bool OnParent
		{
			get
			{
				return this._onParent;
			}
			set
			{
				this._onParent = value;
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
		public string PrivGroupName
		{
			get
			{
				return this._privGroupName;
			}
			set
			{
				this._privGroupName = value;
			}
		}
	}
}
