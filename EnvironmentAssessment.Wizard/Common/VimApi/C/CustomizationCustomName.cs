namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationCustomName : CustomizationName
	{
		protected string _argument;
		public string Argument
		{
			get
			{
				return this._argument;
			}
			set
			{
				this._argument = value;
			}
		}
	}
}
