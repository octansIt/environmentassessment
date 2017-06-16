namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfHostValueNotParsed : OvfSystemFault
	{
		protected string _property;
		protected string _value;
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
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
