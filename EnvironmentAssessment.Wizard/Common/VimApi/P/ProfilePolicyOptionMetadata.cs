namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfilePolicyOptionMetadata : DynamicData
	{
		protected ExtendedElementDescription _id;
		protected ProfileParameterMetadata[] _parameter;
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
		public ProfileParameterMetadata[] Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
