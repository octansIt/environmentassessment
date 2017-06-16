namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDVSConfigSpec : DVSConfigSpec
	{
		protected VMwareDVSPvlanConfigSpec[] _pvlanConfigSpec;
		protected VMwareDVSVspanConfigSpec[] _vspanConfigSpec;
		protected int? _maxMtu;
		protected LinkDiscoveryProtocolConfig _linkDiscoveryProtocolConfig;
		protected VMwareIpfixConfig _ipfixConfig;
		protected string _lacpApiVersion;
		protected string _multicastFilteringMode;
		public VMwareDVSPvlanConfigSpec[] PvlanConfigSpec
		{
			get
			{
				return this._pvlanConfigSpec;
			}
			set
			{
				this._pvlanConfigSpec = value;
			}
		}
		public VMwareDVSVspanConfigSpec[] VspanConfigSpec
		{
			get
			{
				return this._vspanConfigSpec;
			}
			set
			{
				this._vspanConfigSpec = value;
			}
		}
		public int? MaxMtu
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
		public new VMwareDVSConfigSpec_LinkedView LinkedView
		{
			get
			{
				return (VMwareDVSConfigSpec_LinkedView)this._linkedView;
			}
		}
	}
}
