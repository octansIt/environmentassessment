namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallRuleset : DynamicData
	{
		protected string _key;
		protected string _label;
		protected bool _required;
		protected HostFirewallRule[] _rule;
		protected string _service;
		protected bool _enabled;
		protected HostFirewallRulesetIpList _allowedHosts;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				this._label = value;
			}
		}
		public bool Required
		{
			get
			{
				return this._required;
			}
			set
			{
				this._required = value;
			}
		}
		public HostFirewallRule[] Rule
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
		public string Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
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
