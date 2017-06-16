namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDVSConfigInfo : DVSConfigInfo
	{
		protected VMwareVspanSession[] _vspanSession;
		protected VMwareDVSPvlanMapEntry[] _pvlanConfig;
		protected int _maxMtu;
		protected LinkDiscoveryProtocolConfig _linkDiscoveryProtocolConfig;
		protected VMwareIpfixConfig _ipfixConfig;
		protected VMwareDvsLacpGroupConfig[] _lacpGroupConfig;
		protected string _lacpApiVersion;
		protected string _multicastFilteringMode;
		public VMwareVspanSession[] VspanSession
		{
			get
			{
				return this._vspanSession;
			}
			set
			{
				this._vspanSession = value;
			}
		}
		public VMwareDVSPvlanMapEntry[] PvlanConfig
		{
			get
			{
				return this._pvlanConfig;
			}
			set
			{
				this._pvlanConfig = value;
			}
		}
		public int MaxMtu
		{
			get
			{
				return this._maxMtu;
			}
			set
			{
				this._maxMtu = value;
			}
		}
		public LinkDiscoveryProtocolConfig LinkDiscoveryProtocolConfig
		{
			get
			{
				return this._linkDiscoveryProtocolConfig;
			}
			set
			{
				this._linkDiscoveryProtocolConfig = value;
			}
		}
		public VMwareIpfixConfig IpfixConfig
		{
			get
			{
				return this._ipfixConfig;
			}
			set
			{
				this._ipfixConfig = value;
			}
		}
		public VMwareDvsLacpGroupConfig[] LacpGroupConfig
		{
			get
			{
				return this._lacpGroupConfig;
			}
			set
			{
				this._lacpGroupConfig = value;
			}
		}
		public string LacpApiVersion
		{
			get
			{
				return this._lacpApiVersion;
			}
			set
			{
				this._lacpApiVersion = value;
			}
		}
		public string MulticastFilteringMode
		{
			get
			{
				return this._multicastFilteringMode;
			}
			set
			{
				this._multicastFilteringMode = value;
			}
		}
		public new VMwareDVSConfigInfo_LinkedView LinkedView
		{
			get
			{
				return (VMwareDVSConfigInfo_LinkedView)this._linkedView;
			}
		}
	}
}
