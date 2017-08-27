namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationPrefixName : CustomizationName
	{
		protected string _base;
		public string Base
		{
			get
			{
				return this._base;
			}
			set
			{
				this._base = value;
			}
		}
	}
}
