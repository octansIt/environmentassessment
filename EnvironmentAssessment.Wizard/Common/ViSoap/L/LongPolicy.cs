namespace EnvironmentAssessment.Common.VISoap
{
    public class LongPolicy : InheritablePolicy
	{
		protected long? _value;
		public long? Value
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
