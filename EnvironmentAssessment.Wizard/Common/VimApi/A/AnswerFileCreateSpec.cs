namespace EnvironmentAssessment.Common.VimApi
{
	public class AnswerFileCreateSpec : DynamicData
	{
		protected bool? _validating;
		public bool? Validating
		{
			get
			{
				return this._validating;
			}
			set
			{
				this._validating = value;
			}
		}
	}
}
