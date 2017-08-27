namespace EnvironmentAssessment.Common.VimApi
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
