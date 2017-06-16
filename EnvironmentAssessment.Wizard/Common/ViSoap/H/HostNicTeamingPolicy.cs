namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNicTeamingPolicy : DynamicData
	{
		protected string _policy;
		protected bool? _reversePolicy;
		protected bool? _notifySwitches;
		protected bool? _rollingOrder;
		protected HostNicFailureCriteria _failureCriteria;
		protected HostNicOrderPolicy _nicOrder;
		public string Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public bool? ReversePolicy
		{
			get
			{
				return this._reversePolicy;
			}
			set
			{
				this._reversePolicy = value;
			}
		}
		public bool? NotifySwitches
		{
			get
			{
				return this._notifySwitches;
			}
			set
			{
				this._notifySwitches = value;
			}
		}
		public bool? RollingOrder
		{
			get
			{
				return this._rollingOrder;
			}
			set
			{
				this._rollingOrder = value;
			}
		}
		public HostNicFailureCriteria FailureCriteria
		{
			get
			{
				return this._failureCriteria;
			}
			set
			{
				this._failureCriteria = value;
			}
		}
		public HostNicOrderPolicy NicOrder
		{
			get
			{
				return this._nicOrder;
			}
			set
			{
				this._nicOrder = value;
			}
		}
	}
}
