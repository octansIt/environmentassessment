namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileSimpleExpression : ProfileExpression
	{
		protected string _expressionType;
		protected KeyAnyValue[] _parameter;
		public string ExpressionType
		{
			get
			{
				return this._expressionType;
			}
			set
			{
				this._expressionType = value;
			}
		}
		public KeyAnyValue[] Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
