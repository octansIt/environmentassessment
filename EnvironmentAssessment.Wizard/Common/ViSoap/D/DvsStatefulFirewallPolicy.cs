namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsStatefulFirewallPolicy : InheritablePolicy
	{
		protected DvsTrafficRuleset _masterSet;
		protected DvsTrafficRuleset[] _supplementSet;
		public DvsTrafficRuleset MasterSet
		{
			get
			{
				return this._masterSet;
			}
			set
			{
				this._masterSet = value;
			}
		}
		public DvsTrafficRuleset[] SupplementSet
		{
			get
			{
				return this._supplementSet;
			}
			set
			{
				this._supplementSet = value;
			}
		}
	}
}
