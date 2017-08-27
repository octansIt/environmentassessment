namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationPassword : DynamicData
	{
		protected string _value;
		protected bool _plainText;
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
		public bool PlainText
		{
			get
			{
				return this._plainText;
			}
			set
			{
				this._plainText = value;
			}
		}
	}
}
