namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsFilterConfig : InheritablePolicy
	{
		protected string _key;
		protected string _agentName;
		protected string _slotNumber;
		protected DvsFilterParameter _parameters;
		protected string _onFailure;
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
		public string AgentName
		{
			get
			{
				return this._agentName;
			}
			set
			{
				this._agentName = value;
			}
		}
		public string SlotNumber
		{
			get
			{
				return this._slotNumber;
			}
			set
			{
				this._slotNumber = value;
			}
		}
		public DvsFilterParameter Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				this._parameters = value;
			}
		}
		public string OnFailure
		{
			get
			{
				return this._onFailure;
			}
			set
			{
				this._onFailure = value;
			}
		}
	}
}
