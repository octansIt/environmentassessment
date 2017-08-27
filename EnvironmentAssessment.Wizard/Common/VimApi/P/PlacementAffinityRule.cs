namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementAffinityRule : DynamicData
	{
		protected string _ruleType;
		protected string _ruleScope;
		protected ManagedObjectReference[] _vms;
		protected string[] _keys;
		protected PlacementAffinityRule_LinkedView _linkedView;
		public string RuleType
		{
			get
			{
				return this._ruleType;
			}
			set
			{
				this._ruleType = value;
			}
		}
		public string RuleScope
		{
			get
			{
				return this._ruleScope;
			}
			set
			{
				this._ruleScope = value;
			}
		}
		public ManagedObjectReference[] Vms
		{
			get
			{
				return this._vms;
			}
			set
			{
				this._vms = value;
			}
		}
		public string[] Keys
		{
			get
			{
				return this._keys;
			}
			set
			{
				this._keys = value;
			}
		}
		public PlacementAffinityRule_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
