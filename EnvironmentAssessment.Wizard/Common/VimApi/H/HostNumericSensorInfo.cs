namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNumericSensorInfo : DynamicData
	{
		protected string _name;
		protected ElementDescription _healthState;
		protected long _currentReading;
		protected int _unitModifier;
		protected string _baseUnits;
		protected string _rateUnits;
		protected string _sensorType;
		protected string _id;
		protected string _timeStamp;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public ElementDescription HealthState
		{
			get
			{
				return this._healthState;
			}
			set
			{
				this._healthState = value;
			}
		}
		public long CurrentReading
		{
			get
			{
				return this._currentReading;
			}
			set
			{
				this._currentReading = value;
			}
		}
		public int UnitModifier
		{
			get
			{
				return this._unitModifier;
			}
			set
			{
				this._unitModifier = value;
			}
		}
		public string BaseUnits
		{
			get
			{
				return this._baseUnits;
			}
			set
			{
				this._baseUnits = value;
			}
		}
		public string RateUnits
		{
			get
			{
				return this._rateUnits;
			}
			set
			{
				this._rateUnits = value;
			}
		}
		public string SensorType
		{
			get
			{
				return this._sensorType;
			}
			set
			{
				this._sensorType = value;
			}
		}
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string TimeStamp
		{
			get
			{
				return this._timeStamp;
			}
			set
			{
				this._timeStamp = value;
			}
		}
	}
}
