namespace EnvironmentAssessment.Common.VISoap
{
    public class AnswerFileStatusError : DynamicData
	{
		protected ProfilePropertyPath _userInputPath;
		protected LocalizableMessage _errMsg;
		public ProfilePropertyPath UserInputPath
		{
			get
			{
				return this._userInputPath;
			}
			set
			{
				this._userInputPath = value;
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
