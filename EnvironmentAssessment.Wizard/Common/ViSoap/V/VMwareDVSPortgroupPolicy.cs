namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDVSPortgroupPolicy : DVPortgroupPolicy
	{
		protected bool _vlanOverrideAllowed;
		protected bool _uplinkTeamingOverrideAllowed;
		protected bool _securityPolicyOverrideAllowed;
		protected bool? _ipfixOverrideAllowed;
		public bool VlanOverrideAllowed
		{
			get
			{
				return this._vlanOverrideAllowed;
			}
			set
			{
				this._vlanOverrideAllowed = value;
			}
		}
		public bool UplinkTeamingOverrideAllowed
		{
			get
			{
				return this._uplinkTeamingOverrideAllowed;
			}
			set
			{
				this._uplinkTeamingOverrideAllowed = value;
			}
		}
		public bool SecurityPolicyOverrideAllowed
		{
			get
			{
				return this._securityPolicyOverrideAllowed;
			}
			set
			{
				this._securityPolicyOverrideAllowed = value;
			}
		}
		public bool? IpfixOverrideAllowed
		{
			get
			{
				return this._ipfixOverrideAllowed;
			}
			set
			{
				this._ipfixOverrideAllowed = value;
			}
		}
	}
}
