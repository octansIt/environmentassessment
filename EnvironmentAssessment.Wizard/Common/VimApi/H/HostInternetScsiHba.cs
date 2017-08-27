namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHba : HostHostBusAdapter
	{
		protected bool _isSoftwareBased;
		protected bool? _canBeDisabled;
		protected HostInternetScsiHbaNetworkBindingSupportType? _networkBindingSupport;
		protected HostInternetScsiHbaDiscoveryCapabilities _discoveryCapabilities;
		protected HostInternetScsiHbaDiscoveryProperties _discoveryProperties;
		protected HostInternetScsiHbaAuthenticationCapabilities _authenticationCapabilities;
		protected HostInternetScsiHbaAuthenticationProperties _authenticationProperties;
		protected HostInternetScsiHbaDigestCapabilities _digestCapabilities;
		protected HostInternetScsiHbaDigestProperties _digestProperties;
		protected HostInternetScsiHbaIPCapabilities _ipCapabilities;
		protected HostInternetScsiHbaIPProperties _ipProperties;
		protected OptionDef[] _supportedAdvancedOptions;
		protected HostInternetScsiHbaParamValue[] _advancedOptions;
		protected string _iScsiName;
		protected string _iScsiAlias;
		protected HostInternetScsiHbaSendTarget[] _configuredSendTarget;
		protected HostInternetScsiHbaStaticTarget[] _configuredStaticTarget;
		protected int? _maxSpeedMb;
		protected int? _currentSpeedMb;
		public bool IsSoftwareBased
		{
			get
			{
				return this._isSoftwareBased;
			}
			set
			{
				this._isSoftwareBased = value;
			}
		}
		public bool? CanBeDisabled
		{
			get
			{
				return this._canBeDisabled;
			}
			set
			{
				this._canBeDisabled = value;
			}
		}
		public HostInternetScsiHbaNetworkBindingSupportType? NetworkBindingSupport
		{
			get
			{
				return this._networkBindingSupport;
			}
			set
			{
				this._networkBindingSupport = value;
			}
		}
		public HostInternetScsiHbaDiscoveryCapabilities DiscoveryCapabilities
		{
			get
			{
				return this._discoveryCapabilities;
			}
			set
			{
				this._discoveryCapabilities = value;
			}
		}
		public HostInternetScsiHbaDiscoveryProperties DiscoveryProperties
		{
			get
			{
				return this._discoveryProperties;
			}
			set
			{
				this._discoveryProperties = value;
			}
		}
		public HostInternetScsiHbaAuthenticationCapabilities AuthenticationCapabilities
		{
			get
			{
				return this._authenticationCapabilities;
			}
			set
			{
				this._authenticationCapabilities = value;
			}
		}
		public HostInternetScsiHbaAuthenticationProperties AuthenticationProperties
		{
			get
			{
				return this._authenticationProperties;
			}
			set
			{
				this._authenticationProperties = value;
			}
		}
		public HostInternetScsiHbaDigestCapabilities DigestCapabilities
		{
			get
			{
				return this._digestCapabilities;
			}
			set
			{
				this._digestCapabilities = value;
			}
		}
		public HostInternetScsiHbaDigestProperties DigestProperties
		{
			get
			{
				return this._digestProperties;
			}
			set
			{
				this._digestProperties = value;
			}
		}
		public HostInternetScsiHbaIPCapabilities IpCapabilities
		{
			get
			{
				return this._ipCapabilities;
			}
			set
			{
				this._ipCapabilities = value;
			}
		}
		public HostInternetScsiHbaIPProperties IpProperties
		{
			get
			{
				return this._ipProperties;
			}
			set
			{
				this._ipProperties = value;
			}
		}
		public OptionDef[] SupportedAdvancedOptions
		{
			get
			{
				return this._supportedAdvancedOptions;
			}
			set
			{
				this._supportedAdvancedOptions = value;
			}
		}
		public HostInternetScsiHbaParamValue[] AdvancedOptions
		{
			get
			{
				return this._advancedOptions;
			}
			set
			{
				this._advancedOptions = value;
			}
		}
		public string IScsiName
		{
			get
			{
				return this._iScsiName;
			}
			set
			{
				this._iScsiName = value;
			}
		}
		public string IScsiAlias
		{
			get
			{
				return this._iScsiAlias;
			}
			set
			{
				this._iScsiAlias = value;
			}
		}
		public HostInternetScsiHbaSendTarget[] ConfiguredSendTarget
		{
			get
			{
				return this._configuredSendTarget;
			}
			set
			{
				this._configuredSendTarget = value;
			}
		}
		public HostInternetScsiHbaStaticTarget[] ConfiguredStaticTarget
		{
			get
			{
				return this._configuredStaticTarget;
			}
			set
			{
				this._configuredStaticTarget = value;
			}
		}
		public int? MaxSpeedMb
		{
			get
			{
				return this._maxSpeedMb;
			}
			set
			{
				this._maxSpeedMb = value;
			}
		}
		public int? CurrentSpeedMb
		{
			get
			{
				return this._currentSpeedMb;
			}
			set
			{
				this._currentSpeedMb = value;
			}
		}
	}
}
