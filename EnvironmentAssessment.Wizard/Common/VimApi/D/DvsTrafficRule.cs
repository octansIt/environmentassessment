namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsTrafficRule : DynamicData
	{
		protected string _key;
		protected string _description;
		protected int? _sequence;
		protected DvsNetworkRuleQualifier[] _qualifier;
		protected DvsNetworkRuleAction _action;
		protected string _direction;
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
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public int? Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				this._sequence = value;
			}
		}
		public DvsNetworkRuleQualifier[] Qualifier
		{
			get
			{
				return this._qualifier;
			}
			set
			{
				this._qualifier = value;
			}
		}
		public DvsNetworkRuleAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
		public string Direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this._direction = value;
			}
		}
	}
}
