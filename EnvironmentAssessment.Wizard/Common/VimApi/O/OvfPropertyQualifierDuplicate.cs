namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfPropertyQualifierDuplicate : OvfProperty
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
