namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSFailureCriteria : InheritablePolicy
	{
		protected StringPolicy _checkSpeed;
		protected IntPolicy _speed;
		protected BoolPolicy _checkDuplex;
		protected BoolPolicy _fullDuplex;
		protected BoolPolicy _checkErrorPercent;
		protected IntPolicy _percentage;
		protected BoolPolicy _checkBeacon;
		public StringPolicy CheckSpeed
		{
			get
			{
				return this._checkSpeed;
			}
			set
			{
				this._checkSpeed = value;
			}
		}
		public IntPolicy Speed
		{
			get
			{
				return this._speed;
			}
			set
			{
				this._speed = value;
			}
		}
		public BoolPolicy CheckDuplex
		{
			get
			{
				return this._checkDuplex;
			}
			set
			{
				this._checkDuplex = value;
			}
		}
		public BoolPolicy FullDuplex
		{
			get
			{
				return this._fullDuplex;
			}
			set
			{
				this._fullDuplex = value;
			}
		}
		public BoolPolicy CheckErrorPercent
		{
			get
			{
				return this._checkErrorPercent;
			}
			set
			{
				this._checkErrorPercent = value;
			}
		}
		public IntPolicy Percentage
		{
			get
			{
				return this._percentage;
			}
			set
			{
				this._percentage = value;
			}
		}
		public BoolPolicy CheckBeacon
		{
			get
			{
				return this._checkBeacon;
			}
			set
			{
				this._checkBeacon = value;
			}
		}
	}
}
