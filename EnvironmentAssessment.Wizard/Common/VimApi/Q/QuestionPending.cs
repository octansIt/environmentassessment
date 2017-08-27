namespace EnvironmentAssessment.Common.VimApi
{
	public class QuestionPending : InvalidState
	{
		protected string _text;
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
			}
		}
	}
}
