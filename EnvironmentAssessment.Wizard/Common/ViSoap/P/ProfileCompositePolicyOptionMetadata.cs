namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileCompositePolicyOptionMetadata : ProfilePolicyOptionMetadata
	{
		protected string[] _option;
		public string[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
	}
}
