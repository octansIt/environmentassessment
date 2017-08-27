using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSConfigInfo : DynamicData
	{
		protected string _uuid;
		protected string _name;
		protected int _numStandalonePorts;
		protected int _numPorts;
		protected int _maxPorts;
		protected DVSUplinkPortPolicy _uplinkPortPolicy;
		protected ManagedObjectReference[] _uplinkPortgroup;
		protected DVPortSetting _defaultPortConfig;
		protected DistributedVirtualSwitchHostMember[] _host;
		protected DistributedVirtualSwitchProductSpec _productInfo;
		protected DistributedVirtualSwitchProductSpec _targetInfo;
		protected string _extensionKey;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificConfig;
		protected DVSPolicy _policy;
		protected string _description;
		protected string _configVersion;
		protected DVSContactInfo _contact;
		protected string _switchIpAddress;
		protected DateTime _createTime;
		protected bool _networkResourceManagementEnabled;
		protected int? _defaultProxySwitchMaxNumPorts;
		protected DVSHealthCheckConfig[] _healthCheckConfig;
		protected DvsHostInfrastructureTrafficResource[] _infrastructureTrafficResourceConfig;
		protected string _networkResourceControlVersion;
		protected DVSVmVnicNetworkResourcePool[] _vmVnicNetworkResourcePool;
		protected int? _pnicCapacityRatioForReservation;
		protected DVSConfigInfo_LinkedView _linkedView;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
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
		public int NumStandalonePorts
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
		public int MaxPorts
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
		public DistributedVirtualSwitchHostMember[] Host
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
		public DistributedVirtualSwitchProductSpec ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
		public DistributedVirtualSwitchProductSpec TargetInfo
		{
			get
			{
				return this._targetInfo;
			}
			set
			{
				this._targetInfo = value;
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
		public DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				this._createTime = value;
			}
		}
		public bool NetworkResourceManagementEnabled
		{
			get
			{
				return this._networkResourceManagementEnabled;
			}
			set
			{
				this._networkResourceManagementEnabled = value;
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
		public DVSHealthCheckConfig[] HealthCheckConfig
		{
			get
			{
				return this._healthCheckConfig;
			}
			set
			{
				this._healthCheckConfig = value;
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
		public DVSVmVnicNetworkResourcePool[] VmVnicNetworkResourcePool
		{
			get
			{
				return this._vmVnicNetworkResourcePool;
			}
			set
			{
				this._vmVnicNetworkResourcePool = value;
			}
		}
		public int? PnicCapacityRatioForReservation
		{
			get
			{
				return this._pnicCapacityRatioForReservation;
			}
			set
			{
				this._pnicCapacityRatioForReservation = value;
			}
		}
		public DVSConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
