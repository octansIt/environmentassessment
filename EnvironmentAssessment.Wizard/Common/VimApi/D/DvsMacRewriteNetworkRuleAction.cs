namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsMacRewriteNetworkRuleAction : DvsNetworkRuleAction
	{
		protected string _rewriteMac;
		public string RewriteMac
		{
			get
			{
				return this._rewriteMac;
			}
			set
			{
				this._rewriteMac = value;
			}
		}
	}
}
