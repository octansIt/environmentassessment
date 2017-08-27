namespace EnvironmentAssessment.Common.VimApi
{
	public class StringOption : OptionType
	{
		protected string _defaultValue;
		protected string _validCharacters;
		public string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				this._defaultValue = value;
			}
		}
		public string ValidCharacters
		{
			get
			{
				return this._validCharacters;
			}
			set
			{
				this._validCharacters = value;
			}
		}
	}
}
