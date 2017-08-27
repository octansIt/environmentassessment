namespace EnvironmentAssessment.Common.VimApi
{
	public class PerfInterval : DynamicData
	{
		protected int _key;
		protected int _samplingPeriod;
		protected string _name;
		protected int _length;
		protected int? _level;
		protected bool _enabled;
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public int SamplingPeriod
		{
			get
			{
				return this._samplingPeriod;
			}
			set
			{
				this._samplingPeriod = value;
			}
		}
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
		public int Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
		public int? Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this._level = value;
			}
		}
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
	}
}
