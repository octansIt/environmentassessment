namespace EnvironmentAssessment.Common.VimApi
{
	public class FirewallProfile : ApplyProfile
	{
		protected FirewallProfileRulesetProfile[] _ruleset;
		public FirewallProfileRulesetProfile[] Ruleset
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
