namespace EnvironmentAssessment.Common.VISoap
{
    public class AndAlarmExpression : AlarmExpression
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
