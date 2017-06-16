namespace EnvironmentAssessment.Common.VISoap
{
    public class OptionDef : ElementDescription
	{
		protected OptionType _optionType;
		public OptionType OptionType
		{
			get
			{
				return this._optionType;
			}
			set
			{
				this._optionType = value;
			}
		}
	}
}
