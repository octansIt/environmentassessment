namespace EnvironmentAssessment.Common.VimApi
{
	public class LongOption : OptionType
	{
		protected long _min;
		protected long _max;
		protected long _defaultValue;
		public long Min
		{
			get
			{
				return this._min;
			}
			set
			{
				this._min = value;
			}
		}
		public long Max
		{
			get
			{
				return this._max;
			}
			set
			{
				this._max = value;
			}
		}
		public long DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				this._defaultValue = value;
			}
		}
	}
}
