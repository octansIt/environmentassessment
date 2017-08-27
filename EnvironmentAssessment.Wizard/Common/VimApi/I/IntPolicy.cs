namespace EnvironmentAssessment.Common.VimApi
{
	public class IntPolicy : InheritablePolicy
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
