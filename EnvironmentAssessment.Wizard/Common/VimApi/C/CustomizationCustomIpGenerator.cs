namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationCustomIpGenerator : CustomizationIpGenerator
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
