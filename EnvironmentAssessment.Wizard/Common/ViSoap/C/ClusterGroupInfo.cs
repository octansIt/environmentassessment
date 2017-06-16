namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterGroupInfo : DynamicData
	{
		protected string _name;
		protected bool? _userCreated;
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
	}
}
