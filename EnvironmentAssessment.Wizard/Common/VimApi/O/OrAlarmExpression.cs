namespace EnvironmentAssessment.Common.VimApi
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
