namespace EnvironmentAssessment.Common.VimApi
{
	public class ChoiceOption : OptionType
	{
		protected ElementDescription[] _choiceInfo;
		protected int? _defaultIndex;
		public ElementDescription[] ChoiceInfo
		{
			get
			{
				return this._choiceInfo;
			}
			set
			{
				this._choiceInfo = value;
			}
		}
		public int? DefaultIndex
		{
			get
			{
				return this._defaultIndex;
			}
			set
			{
				this._defaultIndex = value;
			}
		}
	}
}
