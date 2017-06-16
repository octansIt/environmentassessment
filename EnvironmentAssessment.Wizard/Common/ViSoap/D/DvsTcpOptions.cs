namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsTcpOptions : NegatableExpression
	{
		protected int _type;
		protected int _length;
		protected string _value;
		public int Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public int Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
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
