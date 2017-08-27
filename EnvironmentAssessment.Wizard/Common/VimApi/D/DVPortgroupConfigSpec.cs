namespace EnvironmentAssessment.Common.VimApi
{
	public class DVPortgroupConfigSpec : DynamicData
	{
		protected string _configVersion;
		protected string _name;
		protected int? _numPorts;
		protected string _portNameFormat;
		protected DVPortSetting _defaultPortConfig;
		protected string _description;
		protected string _type;
		protected ManagedObjectReference[] _scope;
		protected DVPortgroupPolicy _policy;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificConfig;
		protected bool? _autoExpand;
		protected string _vmVnicNetworkResourcePoolKey;
		protected DVPortgroupConfigSpec_LinkedView _linkedView;
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
		public int? NumPorts
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
		public string PortNameFormat
		{
			get
			{
				return this._portNameFormat;
			}
			set
			{
				this._portNameFormat = value;
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
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public ManagedObjectReference[] Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
		public DVPortgroupPolicy Policy
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
		public bool? AutoExpand
		{
			get
			{
				return this._autoExpand;
			}
			set
			{
				this._autoExpand = value;
			}
		}
		public string VmVnicNetworkResourcePoolKey
		{
			get
			{
				return this._vmVnicNetworkResourcePoolKey;
			}
			set
			{
				this._vmVnicNetworkResourcePoolKey = value;
			}
		}
		public DVPortgroupConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
