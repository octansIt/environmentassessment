namespace EnvironmentAssessment.Common.VimApi
{
	public class BoolPolicy : InheritablePolicy
	{
		protected bool? _value;
		public bool? Value
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
