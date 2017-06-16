namespace EnvironmentAssessment.Common.VISoap
{
    public class PortGroupProfile : ApplyProfile
	{
		protected string _key;
		protected string _name;
		protected VlanProfile _vlan;
		protected VirtualSwitchSelectionProfile _vswitch;
		protected NetworkPolicyProfile _networkPolicy;
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
		public VlanProfile Vlan
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
		public VirtualSwitchSelectionProfile Vswitch
		{
			get
			{
				return this._vswitch;
			}
			set
			{
				this._vswitch = value;
			}
		}
		public NetworkPolicyProfile NetworkPolicy
		{
			get
			{
				return this._networkPolicy;
			}
			set
			{
				this._networkPolicy = value;
			}
		}
	}
}
