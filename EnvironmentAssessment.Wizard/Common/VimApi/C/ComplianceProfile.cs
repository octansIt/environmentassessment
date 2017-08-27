namespace EnvironmentAssessment.Common.VimApi
{
	public class ComplianceProfile : DynamicData
	{
		protected ProfileExpression[] _expression;
		protected string _rootExpression;
		public ProfileExpression[] Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				this._expression = value;
			}
		}
		public string RootExpression
		{
			get
			{
				return this._rootExpression;
			}
			set
			{
				this._rootExpression = value;
			}
		}
	}
}
