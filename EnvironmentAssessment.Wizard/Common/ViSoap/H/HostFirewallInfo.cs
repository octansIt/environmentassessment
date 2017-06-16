namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallInfo : DynamicData
	{
		protected HostFirewallDefaultPolicy _defaultPolicy;
		protected HostFirewallRuleset[] _ruleset;
		public HostFirewallDefaultPolicy DefaultPolicy
		{
			get
			{
				return this._defaultPolicy;
			}
			set
			{
				this._defaultPolicy = value;
			}
		}
		public HostFirewallRuleset[] Ruleset
		{
			get
			{
				return this._ruleset;
			}
			set
			{
				this._ruleset = value;
			}
		}
	}
}
