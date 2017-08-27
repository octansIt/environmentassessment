namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileUpdateFailedUpdateFailure : DynamicData
	{
		protected ProfilePropertyPath _profilePath;
		protected LocalizableMessage _errMsg;
		public ProfilePropertyPath ProfilePath
		{
			get
			{
				return this._profilePath;
			}
			set
			{
				this._profilePath = value;
			}
		}
		public LocalizableMessage ErrMsg
		{
			get
			{
				return this._errMsg;
			}
			set
			{
				this._errMsg = value;
			}
		}
	}
}
