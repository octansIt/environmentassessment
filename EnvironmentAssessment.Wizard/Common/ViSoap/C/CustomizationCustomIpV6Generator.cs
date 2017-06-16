namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationCustomIpV6Generator : CustomizationIpV6Generator
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
