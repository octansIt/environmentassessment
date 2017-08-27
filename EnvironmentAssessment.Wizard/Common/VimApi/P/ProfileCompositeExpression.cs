namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileCompositeExpression : ProfileExpression
	{
		protected string _operator;
		protected string[] _expressionName;
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
		public string[] ExpressionName
		{
			get
			{
				return this._expressionName;
			}
			set
			{
				this._expressionName = value;
			}
		}
	}
}
