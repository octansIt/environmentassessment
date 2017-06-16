namespace EnvironmentAssessment.Common.VISoap
{
    public class EventEx : Event
	{
		protected string _eventTypeId;
		protected string _severity;
		protected string _message;
		protected KeyAnyValue[] _arguments;
		protected string _objectId;
		protected string _objectType;
		protected string _objectName;
		protected LocalizedMethodFault _fault;
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
		public string Severity
		{
			get
			{
				return this._severity;
			}
			set
			{
				this._severity = value;
			}
		}
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
		public KeyAnyValue[] Arguments
		{
			get
			{
				return this._arguments;
			}
			set
			{
				this._arguments = value;
			}
		}
		public string ObjectId
		{
			get
			{
				return this._objectId;
			}
			set
			{
				this._objectId = value;
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
		public string ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				this._objectName = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
