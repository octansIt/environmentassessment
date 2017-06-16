namespace EnvironmentAssessment.Common.VISoap
{
    public class AnswerFileSerializedCreateSpec : AnswerFileCreateSpec
	{
		protected string _answerFileConfigString;
		public string AnswerFileConfigString
		{
			get
			{
				return this._answerFileConfigString;
			}
			set
			{
				this._answerFileConfigString = value;
			}
		}
	}
}
