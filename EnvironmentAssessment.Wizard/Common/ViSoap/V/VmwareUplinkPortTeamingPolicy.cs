namespace EnvironmentAssessment.Common.VISoap
{
    public class VmwareUplinkPortTeamingPolicy : InheritablePolicy
	{
		protected StringPolicy _policy;
		protected BoolPolicy _reversePolicy;
		protected BoolPolicy _notifySwitches;
		protected BoolPolicy _rollingOrder;
		protected DVSFailureCriteria _failureCriteria;
		protected VMwareUplinkPortOrderPolicy _uplinkPortOrder;
		public StringPolicy Policy
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
		public BoolPolicy ReversePolicy
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
		public BoolPolicy NotifySwitches
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
		public BoolPolicy RollingOrder
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
		public DVSFailureCriteria FailureCriteria
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
		public VMwareUplinkPortOrderPolicy UplinkPortOrder
		{
			get
			{
				return this._uplinkPortOrder;
			}
			set
			{
				this._uplinkPortOrder = value;
			}
		}
	}
}
