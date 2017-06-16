namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSwitchProfile : ApplyProfile
	{
		protected string _key;
		protected string _name;
		protected LinkProfile _link;
		protected NumPortsProfile _numPorts;
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
		public LinkProfile Link
		{
			get
			{
				return this._link;
			}
			set
			{
				this._link = value;
			}
		}
		public NumPortsProfile NumPorts
		{
			get
			{
				return this._numPorts;
			}
			set
			{
				this._numPorts = value;
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
