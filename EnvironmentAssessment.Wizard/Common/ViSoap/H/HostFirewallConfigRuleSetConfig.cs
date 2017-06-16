namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallConfigRuleSetConfig : DynamicData
	{
		protected string _rulesetId;
		protected bool _enabled;
		protected HostFirewallRulesetIpList _allowedHosts;
		public string RulesetId
		{
			get
			{
				return this._rulesetId;
			}
			set
			{
				this._rulesetId = value;
			}
		}
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public HostFirewallRulesetIpList AllowedHosts
		{
			get
			{
				return this._allowedHosts;
			}
			set
			{
				this._allowedHosts = value;
			}
		}
	}
}
