namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsFilterPolicy : InheritablePolicy
	{
		protected DvsFilterConfig[] _filterConfig;
		public DvsFilterConfig[] FilterConfig
		{
			get
			{
				return this._filterConfig;
			}
			set
			{
				this._filterConfig = value;
			}
		}
	}
}
