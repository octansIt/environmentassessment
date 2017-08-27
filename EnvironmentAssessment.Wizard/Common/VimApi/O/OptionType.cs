namespace EnvironmentAssessment.Common.VimApi
{
	public class OptionType : DynamicData
	{
		protected bool? _valueIsReadonly;
		public bool? ValueIsReadonly
		{
			get
			{
				return this._valueIsReadonly;
			}
			set
			{
				this._valueIsReadonly = value;
			}
		}
	}
}
