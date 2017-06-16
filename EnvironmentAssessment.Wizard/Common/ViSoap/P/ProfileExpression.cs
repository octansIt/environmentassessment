namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileExpression : DynamicData
	{
		protected string _id;
		protected string _displayName;
		protected bool _negated;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string DisplayName
		{
			get
			{
				return this._displayName;
			}
			set
			{
				this._displayName = value;
			}
		}
		public bool Negated
		{
			get
			{
				return this._negated;
			}
			set
			{
				this._negated = value;
			}
		}
	}
}
