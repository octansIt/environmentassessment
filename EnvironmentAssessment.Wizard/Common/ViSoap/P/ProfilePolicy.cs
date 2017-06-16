namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfilePolicy : DynamicData
	{
		protected string _id;
		protected PolicyOption _policyOption;
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
		public PolicyOption PolicyOption
		{
			get
			{
				return this._policyOption;
			}
			set
			{
				this._policyOption = value;
			}
		}
	}
}
