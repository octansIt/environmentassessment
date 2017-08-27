namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfilePolicyMetadata : DynamicData
	{
		protected ExtendedElementDescription _id;
		protected ProfilePolicyOptionMetadata[] _possibleOption;
		public ExtendedElementDescription Id
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
		public ProfilePolicyOptionMetadata[] PossibleOption
		{
			get
			{
				return this._possibleOption;
			}
			set
			{
				this._possibleOption = value;
			}
		}
	}
}
