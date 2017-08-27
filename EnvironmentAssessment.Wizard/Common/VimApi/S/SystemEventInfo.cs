namespace EnvironmentAssessment.Common.VimApi
{
	public class SystemEventInfo : DynamicData
	{
		protected long _recordId;
		protected string _when;
		protected long _selType;
		protected string _message;
		protected long _sensorNumber;
		public long RecordId
		{
			get
			{
				return this._recordId;
			}
			set
			{
				this._recordId = value;
			}
		}
		public string When
		{
			get
			{
				return this._when;
			}
			set
			{
				this._when = value;
			}
		}
		public long SelType
		{
			get
			{
				return this._selType;
			}
			set
			{
				this._selType = value;
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
		public long SensorNumber
		{
			get
			{
				return this._sensorNumber;
			}
			set
			{
				this._sensorNumber = value;
			}
		}
	}
}
