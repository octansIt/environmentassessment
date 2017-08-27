namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterRuleInfo : DynamicData
	{
		protected int? _key;
		protected ManagedEntityStatus? _status;
		protected bool? _enabled;
		protected string _name;
		protected bool? _mandatory;
		protected bool? _userCreated;
		protected bool? _inCompliance;
		protected string _ruleUuid;
		public int? Key
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
		public ManagedEntityStatus? Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public bool? Enabled
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public bool? Mandatory
		{
			get
			{
				return this._mandatory;
			}
			set
			{
				this._mandatory = value;
			}
		}
		public bool? UserCreated
		{
			get
			{
				return this._userCreated;
			}
			set
			{
				this._userCreated = value;
			}
		}
		public bool? InCompliance
		{
			get
			{
				return this._inCompliance;
			}
			set
			{
				this._inCompliance = value;
			}
		}
		public string RuleUuid
		{
			get
			{
				return this._ruleUuid;
			}
			set
			{
				this._ruleUuid = value;
			}
		}
	}
}
