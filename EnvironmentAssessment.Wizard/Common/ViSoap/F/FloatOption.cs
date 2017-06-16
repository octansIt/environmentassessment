namespace EnvironmentAssessment.Common.VISoap
{
    public class FloatOption : OptionType
	{
		protected float _min;
		protected float _max;
		protected float _defaultValue;
		public float Min
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
		public float Max
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
		public float DefaultValue
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
