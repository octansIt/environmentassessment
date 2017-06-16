namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallConfig : DynamicData
	{
		protected HostFirewallConfigRuleSetConfig[] _rule;
		protected HostFirewallDefaultPolicy _defaultBlockingPolicy;
		public HostFirewallConfigRuleSetConfig[] Rule
		{
			get
			{
				return this._rule;
			}
			set
			{
				this._rule = value;
			}
		}
		public HostFirewallDefaultPolicy DefaultBlockingPolicy
		{
			get
			{
				return this._defaultBlockingPolicy;
			}
			set
			{
				this._defaultBlockingPolicy = value;
			}
		}
	}
}
