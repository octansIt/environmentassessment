namespace EnvironmentAssessment.Common.VISoap
{
    public class IntExpression : NegatableExpression
	{
		protected int? _value;
		public int? Value
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
