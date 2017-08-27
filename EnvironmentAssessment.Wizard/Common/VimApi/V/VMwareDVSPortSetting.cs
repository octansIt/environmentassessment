namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSPortSetting : DVPortSetting
	{
		protected VmwareDistributedVirtualSwitchVlanSpec _vlan;
		protected IntPolicy _qosTag;
		protected VmwareUplinkPortTeamingPolicy _uplinkTeamingPolicy;
		protected DVSSecurityPolicy _securityPolicy;
		protected BoolPolicy _ipfixEnabled;
		protected BoolPolicy _txUplink;
		protected VMwareUplinkLacpPolicy _lacpPolicy;
		public VmwareDistributedVirtualSwitchVlanSpec Vlan
		{
			get
			{
				return this._vlan;
			}
			set
			{
				this._vlan = value;
			}
		}
		public IntPolicy QosTag
		{
			get
			{
				return this._qosTag;
			}
			set
			{
				this._qosTag = value;
			}
		}
		public VmwareUplinkPortTeamingPolicy UplinkTeamingPolicy
		{
			get
			{
				return this._uplinkTeamingPolicy;
			}
			set
			{
				this._uplinkTeamingPolicy = value;
			}
		}
		public DVSSecurityPolicy SecurityPolicy
		{
			get
			{
				return this._securityPolicy;
			}
			set
			{
				this._securityPolicy = value;
			}
		}
		public BoolPolicy IpfixEnabled
		{
			get
			{
				return this._ipfixEnabled;
			}
			set
			{
				this._ipfixEnabled = value;
			}
		}
		public BoolPolicy TxUplink
		{
			get
			{
				return this._txUplink;
			}
			set
			{
				this._txUplink = value;
			}
		}
		public VMwareUplinkLacpPolicy LacpPolicy
		{
			get
			{
				return this._lacpPolicy;
			}
			set
			{
				this._lacpPolicy = value;
			}
		}
	}
}
