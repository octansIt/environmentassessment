namespace EnvironmentAssessment.Common.VimApi
{
	public class IntOption : OptionType
	{
		protected int _min;
		protected int _max;
		protected int _defaultValue;
		public int Min
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
		public int Max
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
		public int DefaultValue
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
