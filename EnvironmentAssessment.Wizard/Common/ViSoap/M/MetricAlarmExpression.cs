namespace EnvironmentAssessment.Common.VISoap
{
    public class MetricAlarmExpression : AlarmExpression
	{
		protected MetricAlarmOperator _operator;
		protected string _type;
		protected PerfMetricId _metric;
		protected int? _yellow;
		protected int? _yellowInterval;
		protected int? _red;
		protected int? _redInterval;
		public MetricAlarmOperator Operator
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
		public PerfMetricId Metric
		{
			get
			{
				return this._metric;
			}
			set
			{
				this._metric = value;
			}
		}
		public int? Yellow
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
		public int? YellowInterval
		{
			get
			{
				return this._yellowInterval;
			}
			set
			{
				this._yellowInterval = value;
			}
		}
		public int? Red
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
		public int? RedInterval
		{
			get
			{
				return this._redInterval;
			}
			set
			{
				this._redInterval = value;
			}
		}
	}
}
