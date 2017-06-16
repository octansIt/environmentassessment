namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationSysprepText : CustomizationIdentitySettings
	{
		protected string _value;
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
