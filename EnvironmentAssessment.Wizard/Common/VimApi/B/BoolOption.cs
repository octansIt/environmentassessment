namespace EnvironmentAssessment.Common.VimApi
{
	public class BoolOption : OptionType
	{
		protected bool _supported;
		protected bool _defaultValue;
		public bool Supported
		{
			get
			{
				return this._supported;
			}
			set
			{
				this._supported = value;
			}
		}
		public bool DefaultValue
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
	}
}
