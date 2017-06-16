namespace EnvironmentAssessment.Common.VISoap
{
    public class KeyAnyValue : DynamicData
	{
		protected string _key;
		protected object _value;
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
		public object Value
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
