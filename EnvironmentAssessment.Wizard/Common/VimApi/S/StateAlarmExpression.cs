namespace EnvironmentAssessment.Common.VimApi
{
	public class StateAlarmExpression : AlarmExpression
	{
		protected StateAlarmOperator _operator;
		protected string _type;
		protected string _statePath;
		protected string _yellow;
		protected string _red;
		public StateAlarmOperator Operator
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
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string StatePath
		{
			get
			{
				return this._statePath;
			}
			set
			{
				this._statePath = value;
			}
		}
		public string Yellow
		{
			get
			{
				return this._yellow;
			}
			set
			{
				this._yellow = value;
			}
		}
		public string Red
		{
			get
			{
				return this._red;
			}
			set
			{
				this._red = value;
			}
		}
	}
}
