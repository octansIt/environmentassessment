namespace EnvironmentAssessment.Common.VISoap
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
