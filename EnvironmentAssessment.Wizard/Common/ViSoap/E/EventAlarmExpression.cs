namespace EnvironmentAssessment.Common.VISoap
{
    public class EventAlarmExpression : AlarmExpression
	{
		protected EventAlarmExpressionComparison[] _comparisons;
		protected string _eventType;
		protected string _eventTypeId;
		protected string _objectType;
		protected ManagedEntityStatus? _status;
		public EventAlarmExpressionComparison[] Comparisons
		{
			get
			{
				return this._comparisons;
			}
			set
			{
				this._comparisons = value;
			}
		}
		public string EventType
		{
			get
			{
				return this._eventType;
			}
			set
			{
				this._eventType = value;
			}
		}
		public string EventTypeId
		{
			get
			{
				return this._eventTypeId;
			}
			set
			{
				this._eventTypeId = value;
			}
		}
		public string ObjectType
		{
			get
			{
				return this._objectType;
			}
			set
			{
				this._objectType = value;
			}
		}
		public ManagedEntityStatus? Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
	}
}
