namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProxySwitch : DynamicData
	{
		protected string _dvsUuid;
		protected string _dvsName;
		protected string _key;
		protected int _numPorts;
		protected int? _configNumPorts;
		protected int _numPortsAvailable;
		protected KeyValue[] _uplinkPort;
		protected int? _mtu;
		protected string[] _pnic;
		protected HostProxySwitchSpec _spec;
		protected HostProxySwitchHostLagConfig[] _hostLag;
		protected bool? _networkReservationSupported;
		public string DvsUuid
		{
			get
			{
				return this._dvsUuid;
			}
			set
			{
				this._dvsUuid = value;
			}
		}
		public string DvsName
		{
			get
			{
				return this._dvsName;
			}
			set
			{
				this._dvsName = value;
			}
		}
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
		public int NumPorts
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
		public int? ConfigNumPorts
		{
			get
			{
				return this._configNumPorts;
			}
			set
			{
				this._configNumPorts = value;
			}
		}
		public int NumPortsAvailable
		{
			get
			{
				return this._numPortsAvailable;
			}
			set
			{
				this._numPortsAvailable = value;
			}
		}
		public KeyValue[] UplinkPort
		{
			get
			{
				return this._uplinkPort;
			}
			set
			{
				this._uplinkPort = value;
			}
		}
		public int? Mtu
		{
			get
			{
				return this._mtu;
			}
			set
			{
				this._mtu = value;
			}
		}
		public string[] Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
		public HostProxySwitchSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
		public HostProxySwitchHostLagConfig[] HostLag
		{
			get
			{
				return this._hostLag;
			}
			set
			{
				this._hostLag = value;
			}
		}
		public bool? NetworkReservationSupported
		{
			get
			{
				return this._networkReservationSupported;
			}
			set
			{
				this._networkReservationSupported = value;
			}
		}
	}
}
