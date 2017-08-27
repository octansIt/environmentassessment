namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterGroupInfo : DynamicData
	{
		protected string _name;
		protected bool? _userCreated;
		protected string _uniqueID;
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
		public bool? UserCreated
		{
			get
			{
				return this._userCreated;
			}
			set
			{
				this._userCreated = value;
			}
		}
		public string UniqueID
		{
			get
			{
				return this._uniqueID;
			}
			set
			{
				this._uniqueID = value;
			}
		}
	}
}
