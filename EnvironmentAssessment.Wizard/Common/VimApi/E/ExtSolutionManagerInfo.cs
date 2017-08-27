namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtSolutionManagerInfo : DynamicData
	{
		protected ExtSolutionManagerInfoTabInfo[] _tab;
		protected string _smallIconUrl;
		public ExtSolutionManagerInfoTabInfo[] Tab
		{
			get
			{
				return this._tab;
			}
			set
			{
				this._tab = value;
			}
		}
		public string SmallIconUrl
		{
			get
			{
				return this._smallIconUrl;
			}
			set
			{
				this._smallIconUrl = value;
			}
		}
	}
}
