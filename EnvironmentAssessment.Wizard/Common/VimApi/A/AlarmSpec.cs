namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmSpec : DynamicData
	{
		protected string _name;
		protected string _systemName;
		protected string _description;
		protected bool _enabled;
		protected AlarmExpression _expression;
		protected AlarmAction _action;
		protected int? _actionFrequency;
		protected AlarmSetting _setting;
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
		public string SystemName
		{
			get
			{
				return this._systemName;
			}
			set
			{
				this._systemName = value;
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
		public AlarmExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				this._expression = value;
			}
		}
		public AlarmAction Action
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
		public int? ActionFrequency
		{
			get
			{
				return this._actionFrequency;
			}
			set
			{
				this._actionFrequency = value;
			}
		}
		public AlarmSetting Setting
		{
			get
			{
				return this._setting;
			}
			set
			{
				this._setting = value;
			}
		}
	}
}
