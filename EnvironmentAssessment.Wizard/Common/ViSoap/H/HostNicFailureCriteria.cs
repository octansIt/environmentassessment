namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNicFailureCriteria : DynamicData
	{
		protected string _checkSpeed;
		protected int? _speed;
		protected bool? _checkDuplex;
		protected bool? _fullDuplex;
		protected bool? _checkErrorPercent;
		protected int? _percentage;
		protected bool? _checkBeacon;
		public string CheckSpeed
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
		public int? Speed
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
		public bool? CheckDuplex
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
		public bool? FullDuplex
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
		public bool? CheckErrorPercent
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
		public int? Percentage
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
		public bool? CheckBeacon
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
