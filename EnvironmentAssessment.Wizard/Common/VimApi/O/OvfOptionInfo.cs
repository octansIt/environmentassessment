namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfOptionInfo : DynamicData
	{
		protected string _option;
		protected LocalizableMessage _description;
		public string Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
		public LocalizableMessage Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
