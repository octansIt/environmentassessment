namespace EnvironmentAssessment.Common.VISoap
{
    public class HostRuntimeInfoNetStackInstanceRuntimeInfo : DynamicData
	{
		protected string _netStackInstanceKey;
		protected string _state;
		protected string[] _vmknicKeys;
		protected int? _maxNumberOfConnections;
		protected bool? _currentIpV6Enabled;
		public string NetStackInstanceKey
		{
			get
			{
				return this._netStackInstanceKey;
			}
			set
			{
				this._netStackInstanceKey = value;
			}
		}
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public string[] VmknicKeys
		{
			get
			{
				return this._vmknicKeys;
			}
			set
			{
				this._vmknicKeys = value;
			}
		}
		public int? MaxNumberOfConnections
		{
			get
			{
				return this._maxNumberOfConnections;
			}
			set
			{
				this._maxNumberOfConnections = value;
			}
		}
		public bool? CurrentIpV6Enabled
		{
			get
			{
				return this._currentIpV6Enabled;
			}
			set
			{
				this._currentIpV6Enabled = value;
			}
		}
	}
}
