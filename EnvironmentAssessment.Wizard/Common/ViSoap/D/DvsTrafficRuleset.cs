namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsTrafficRuleset : DynamicData
	{
		protected string _key;
		protected bool? _enabled;
		protected int? _precedence;
		protected DvsTrafficRule[] _rules;
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
		public int? Precedence
		{
			get
			{
				return this._precedence;
			}
			set
			{
				this._precedence = value;
			}
		}
		public DvsTrafficRule[] Rules
		{
			get
			{
				return this._rules;
			}
			set
			{
				this._rules = value;
			}
		}
	}
}
