namespace EnvironmentAssessment.Common.VISoap
{
    public class OrAlarmExpression : AlarmExpression
	{
		protected AlarmExpression[] _expression;
		public AlarmExpression[] Expression
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
	}
}
