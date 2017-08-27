namespace EnvironmentAssessment.Common.VimApi
{
	public class EventAlarmExpressionComparison : DynamicData
	{
		protected string _attributeName;
		protected string _operator;
		protected string _value;
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				this._attributeName = value;
			}
		}
		public string Operator
		{
			get
			{
				return this._operator;
			}
			set
			{
				this._operator = value;
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
