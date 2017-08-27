namespace EnvironmentAssessment.Common.VimApi
{
	public class MethodActionArgument : DynamicData
	{
		protected object _value;
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
