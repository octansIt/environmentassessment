namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtendedEventPair : DynamicData
	{
		protected string _key;
		protected string _value;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
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
