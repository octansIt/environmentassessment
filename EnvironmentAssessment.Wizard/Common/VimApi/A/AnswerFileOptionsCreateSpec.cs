namespace EnvironmentAssessment.Common.VimApi
{
	public class AnswerFileOptionsCreateSpec : AnswerFileCreateSpec
	{
		protected ProfileDeferredPolicyOptionParameter[] _userInput;
		public ProfileDeferredPolicyOptionParameter[] UserInput
		{
			get
			{
				return this._userInput;
			}
			set
			{
				this._userInput = value;
			}
		}
	}
}
