namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationSpecItem : DynamicData
	{
		protected CustomizationSpecInfo _info;
		protected CustomizationSpec _spec;
		public CustomizationSpecInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
		public CustomizationSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
