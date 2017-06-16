namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfPropertyQualifier : OvfProperty
	{
		protected string _qualifier;
		public string Qualifier
		{
			get
			{
				return this._qualifier;
			}
			set
			{
				this._qualifier = value;
			}
		}
	}
}
