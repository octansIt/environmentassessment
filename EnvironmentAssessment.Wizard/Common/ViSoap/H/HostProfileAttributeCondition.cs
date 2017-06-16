namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileAttributeCondition : DynamicData
	{
		protected string _operator;
		protected object _compareValue;
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
		public object CompareValue
		{
			get
			{
				return this._compareValue;
			}
			set
			{
				this._compareValue = value;
			}
		}
	}
}
