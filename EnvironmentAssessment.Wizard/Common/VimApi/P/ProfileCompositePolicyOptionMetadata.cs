namespace EnvironmentAssessment.Common.VimApi
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
