namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsAutomationConfig : DynamicData
	{
		protected string _spaceLoadBalanceAutomationMode;
		protected string _ioLoadBalanceAutomationMode;
		protected string _ruleEnforcementAutomationMode;
		protected string _policyEnforcementAutomationMode;
		protected string _vmEvacuationAutomationMode;
		public string SpaceLoadBalanceAutomationMode
		{
			get
			{
				return this._spaceLoadBalanceAutomationMode;
			}
			set
			{
				this._spaceLoadBalanceAutomationMode = value;
			}
		}
		public string IoLoadBalanceAutomationMode
		{
			get
			{
				return this._ioLoadBalanceAutomationMode;
			}
			set
			{
				this._ioLoadBalanceAutomationMode = value;
			}
		}
		public string RuleEnforcementAutomationMode
		{
			get
			{
				return this._ruleEnforcementAutomationMode;
			}
			set
			{
				this._ruleEnforcementAutomationMode = value;
			}
		}
		public string PolicyEnforcementAutomationMode
		{
			get
			{
				return this._policyEnforcementAutomationMode;
			}
			set
			{
				this._policyEnforcementAutomationMode = value;
			}
		}
		public string VmEvacuationAutomationMode
		{
			get
			{
				return this._vmEvacuationAutomationMode;
			}
			set
			{
				this._vmEvacuationAutomationMode = value;
			}
		}
	}
}
