namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfCreateImportSpecParams : OvfManagerCommonParams
	{
		protected string _entityName;
		protected ManagedObjectReference _hostSystem;
		protected OvfNetworkMapping[] _networkMapping;
		protected string _ipAllocationPolicy;
		protected string _ipProtocol;
		protected KeyValue[] _propertyMapping;
		protected OvfResourceMap[] _resourceMapping;
		protected string _diskProvisioning;
		protected OvfConsumerOstNode _instantiationOst;
		protected OvfCreateImportSpecParams_LinkedView _linkedView;
		public string EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				this._entityName = value;
			}
		}
		public ManagedObjectReference HostSystem
		{
			get
			{
				return this._hostSystem;
			}
			set
			{
				this._hostSystem = value;
			}
		}
		public OvfNetworkMapping[] NetworkMapping
		{
			get
			{
				return this._networkMapping;
			}
			set
			{
				this._networkMapping = value;
			}
		}
		public string IpAllocationPolicy
		{
			get
			{
				return this._ipAllocationPolicy;
			}
			set
			{
				this._ipAllocationPolicy = value;
			}
		}
		public string IpProtocol
		{
			get
			{
				return this._ipProtocol;
			}
			set
			{
				this._ipProtocol = value;
			}
		}
		public KeyValue[] PropertyMapping
		{
			get
			{
				return this._propertyMapping;
			}
			set
			{
				this._propertyMapping = value;
			}
		}
		public OvfResourceMap[] ResourceMapping
		{
			get
			{
				return this._resourceMapping;
			}
			set
			{
				this._resourceMapping = value;
			}
		}
		public string DiskProvisioning
		{
			get
			{
				return this._diskProvisioning;
			}
			set
			{
				this._diskProvisioning = value;
			}
		}
		public OvfConsumerOstNode InstantiationOst
		{
			get
			{
				return this._instantiationOst;
			}
			set
			{
				this._instantiationOst = value;
			}
		}
		public OvfCreateImportSpecParams_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
