namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallRule : DynamicData
	{
		protected int _port;
		protected int? _endPort;
		protected HostFirewallRuleDirection _direction;
		protected HostFirewallRulePortType? _portType;
		protected string _protocol;
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public int? EndPort
		{
			get
			{
				return this._endPort;
			}
			set
			{
				this._endPort = value;
			}
		}
		public HostFirewallRuleDirection Direction
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
		public HostFirewallRulePortType? PortType
		{
			get
			{
				return this._portType;
			}
			set
			{
				this._portType = value;
			}
		}
		public string Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
	}
}
