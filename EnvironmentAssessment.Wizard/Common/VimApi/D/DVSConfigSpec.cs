namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSConfigSpec : DynamicData
	{
		protected string _configVersion;
		protected string _name;
		protected int? _numStandalonePorts;
		protected int? _maxPorts;
		protected DVSUplinkPortPolicy _uplinkPortPolicy;
		protected ManagedObjectReference[] _uplinkPortgroup;
		protected DVPortSetting _defaultPortConfig;
		protected DistributedVirtualSwitchHostMemberConfigSpec[] _host;
		protected string _extensionKey;
		protected string _description;
		protected DVSPolicy _policy;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificConfig;
		protected DVSContactInfo _contact;
		protected string _switchIpAddress;
		protected int? _defaultProxySwitchMaxNumPorts;
		protected DvsHostInfrastructureTrafficResource[] _infrastructureTrafficResourceConfig;
		protected string _networkResourceControlVersion;
		protected DVSConfigSpec_LinkedView _linkedView;
		public string ConfigVersion
		{
			get
			{
				return this._configVersion;
			}
			set
			{
				this._configVersion = value;
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
		public int? NumStandalonePorts
		{
			get
			{
				return this._numStandalonePorts;
			}
			set
			{
				this._numStandalonePorts = value;
			}
		}
		public int? MaxPorts
		{
			get
			{
				return this._maxPorts;
			}
			set
			{
				this._maxPorts = value;
			}
		}
		public DVSUplinkPortPolicy UplinkPortPolicy
		{
			get
			{
				return this._uplinkPortPolicy;
			}
			set
			{
				this._uplinkPortPolicy = value;
			}
		}
		public ManagedObjectReference[] UplinkPortgroup
		{
			get
			{
				return this._uplinkPortgroup;
			}
			set
			{
				this._uplinkPortgroup = value;
			}
		}
		public DVPortSetting DefaultPortConfig
		{
			get
			{
				return this._defaultPortConfig;
			}
			set
			{
				this._defaultPortConfig = value;
			}
		}
		public DistributedVirtualSwitchHostMemberConfigSpec[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string ExtensionKey
		{
			get
			{
				return this._extensionKey;
			}
			set
			{
				this._extensionKey = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public DVSPolicy Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public DistributedVirtualSwitchKeyedOpaqueBlob[] VendorSpecificConfig
		{
			get
			{
				return this._vendorSpecificConfig;
			}
			set
			{
				this._vendorSpecificConfig = value;
			}
		}
		public DVSContactInfo Contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				this._contact = value;
			}
		}
		public string SwitchIpAddress
		{
			get
			{
				return this._switchIpAddress;
			}
			set
			{
				this._switchIpAddress = value;
			}
		}
		public int? DefaultProxySwitchMaxNumPorts
		{
			get
			{
				return this._defaultProxySwitchMaxNumPorts;
			}
			set
			{
				this._defaultProxySwitchMaxNumPorts = value;
			}
		}
		public DvsHostInfrastructureTrafficResource[] InfrastructureTrafficResourceConfig
		{
			get
			{
				return this._infrastructureTrafficResourceConfig;
			}
			set
			{
				this._infrastructureTrafficResourceConfig = value;
			}
		}
		public string NetworkResourceControlVersion
		{
			get
			{
				return this._networkResourceControlVersion;
			}
			set
			{
				this._networkResourceControlVersion = value;
			}
		}
		public DVSConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
