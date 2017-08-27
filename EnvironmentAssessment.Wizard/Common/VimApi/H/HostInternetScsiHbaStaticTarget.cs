namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaStaticTarget : DynamicData
	{
		protected string _address;
		protected int? _port;
		protected string _iScsiName;
		protected string _discoveryMethod;
		protected HostInternetScsiHbaAuthenticationProperties _authenticationProperties;
		protected HostInternetScsiHbaDigestProperties _digestProperties;
		protected OptionDef[] _supportedAdvancedOptions;
		protected HostInternetScsiHbaParamValue[] _advancedOptions;
		protected string _parent;
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		public int? Port
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
		public string DiscoveryMethod
		{
			get
			{
				return this._discoveryMethod;
			}
			set
			{
				this._discoveryMethod = value;
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
		public string Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
	}
}
