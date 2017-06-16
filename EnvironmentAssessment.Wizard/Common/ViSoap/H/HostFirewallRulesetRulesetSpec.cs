namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallRulesetRulesetSpec : DynamicData
	{
		protected HostFirewallRulesetIpList _allowedHosts;
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
