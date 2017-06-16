namespace EnvironmentAssessment.Common.VISoap
{
    public class StorageDrsPodConfigInfo : DynamicData
	{
		protected bool _enabled;
		protected bool _ioLoadBalanceEnabled;
		protected string _defaultVmBehavior;
		protected int? _loadBalanceInterval;
		protected bool? _defaultIntraVmAffinity;
		protected StorageDrsSpaceLoadBalanceConfig _spaceLoadBalanceConfig;
		protected StorageDrsIoLoadBalanceConfig _ioLoadBalanceConfig;
		protected string _ruleEnforcementAutomationMode;
		protected string _policyEnforcementAutomationMode;
		protected string _vmEvacuationAutomationMode;
		protected StorageDrsAutomationConfig _automationOverrides;
		protected ClusterRuleInfo[] _rule;
		protected OptionValue[] _option;
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
		public bool IoLoadBalanceEnabled
		{
			get
			{
				return this._ioLoadBalanceEnabled;
			}
			set
			{
				this._ioLoadBalanceEnabled = value;
			}
		}
		public string DefaultVmBehavior
		{
			get
			{
				return this._defaultVmBehavior;
			}
			set
			{
				this._defaultVmBehavior = value;
			}
		}
		public int? LoadBalanceInterval
		{
			get
			{
				return this._loadBalanceInterval;
			}
			set
			{
				this._loadBalanceInterval = value;
			}
		}
		public bool? DefaultIntraVmAffinity
		{
			get
			{
				return this._defaultIntraVmAffinity;
			}
			set
			{
				this._defaultIntraVmAffinity = value;
			}
		}
		public StorageDrsSpaceLoadBalanceConfig SpaceLoadBalanceConfig
		{
			get
			{
				return this._spaceLoadBalanceConfig;
			}
			set
			{
				this._spaceLoadBalanceConfig = value;
			}
		}
		public StorageDrsIoLoadBalanceConfig IoLoadBalanceConfig
		{
			get
			{
				return this._ioLoadBalanceConfig;
			}
			set
			{
				this._ioLoadBalanceConfig = value;
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
		public StorageDrsAutomationConfig AutomationOverrides
		{
			get
			{
				return this._automationOverrides;
			}
			set
			{
				this._automationOverrides = value;
			}
		}
		public ClusterRuleInfo[] Rule
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
		public OptionValue[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
	}
}
