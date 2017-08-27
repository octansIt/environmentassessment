namespace EnvironmentAssessment.Common.VimApi
{
	public class UserInputRequiredParameterMetadata : ProfilePolicyOptionMetadata
	{
		protected ProfileParameterMetadata[] _userInputParameter;
		public ProfileParameterMetadata[] UserInputParameter
		{
			get
			{
				return this._userInputParameter;
			}
			set
			{
				this._userInputParameter = value;
			}
		}
	}
}
