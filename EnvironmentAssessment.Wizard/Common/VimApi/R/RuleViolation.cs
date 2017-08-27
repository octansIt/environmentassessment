namespace EnvironmentAssessment.Common.VimApi
{
	public class RuleViolation : VmConfigFault
	{
		protected ManagedObjectReference _host;
		protected ClusterRuleInfo _rule;
		protected RuleViolation_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ClusterRuleInfo Rule
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
		public RuleViolation_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
