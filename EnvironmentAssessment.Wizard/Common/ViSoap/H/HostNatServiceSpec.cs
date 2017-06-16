namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNatServiceSpec : DynamicData
	{
		protected string _virtualSwitch;
		protected bool _activeFtp;
		protected bool _allowAnyOui;
		protected bool _configPort;
		protected string _ipGatewayAddress;
		protected int _udpTimeout;
		protected HostNatServicePortForwardSpec[] _portForward;
		protected HostNatServiceNameServiceSpec _nameService;
		public string VirtualSwitch
		{
			get
			{
				return this._virtualSwitch;
			}
			set
			{
				this._virtualSwitch = value;
			}
		}
		public bool ActiveFtp
		{
			get
			{
				return this._activeFtp;
			}
			set
			{
				this._activeFtp = value;
			}
		}
		public bool AllowAnyOui
		{
			get
			{
				return this._allowAnyOui;
			}
			set
			{
				this._allowAnyOui = value;
			}
		}
		public bool ConfigPort
		{
			get
			{
				return this._configPort;
			}
			set
			{
				this._configPort = value;
			}
		}
		public string IpGatewayAddress
		{
			get
			{
				return this._ipGatewayAddress;
			}
			set
			{
				this._ipGatewayAddress = value;
			}
		}
		public int UdpTimeout
		{
			get
			{
				return this._udpTimeout;
			}
			set
			{
				this._udpTimeout = value;
			}
		}
		public HostNatServicePortForwardSpec[] PortForward
		{
			get
			{
				return this._portForward;
			}
			set
			{
				this._portForward = value;
			}
		}
		public HostNatServiceNameServiceSpec NameService
		{
			get
			{
				return this._nameService;
			}
			set
			{
				this._nameService = value;
			}
		}
	}
}
