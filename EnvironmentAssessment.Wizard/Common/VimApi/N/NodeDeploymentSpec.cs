namespace EnvironmentAssessment.Common.VimApi
{
	public class NodeDeploymentSpec : DynamicData
	{
		protected ManagedObjectReference _esxHost;
		protected ManagedObjectReference _datastore;
		protected ManagedObjectReference _publicNetworkPortGroup;
		protected ManagedObjectReference _clusterNetworkPortGroup;
		protected ManagedObjectReference _folder;
		protected ManagedObjectReference _resourcePool;
		protected ServiceLocator _managementVc;
		protected string _nodeName;
		protected CustomizationIPSettings _ipSettings;
		protected NodeDeploymentSpec_LinkedView _linkedView;
		public ManagedObjectReference EsxHost
		{
			get
			{
				return this._esxHost;
			}
			set
			{
				this._esxHost = value;
			}
		}
		public ManagedObjectReference Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public ManagedObjectReference PublicNetworkPortGroup
		{
			get
			{
				return this._publicNetworkPortGroup;
			}
			set
			{
				this._publicNetworkPortGroup = value;
			}
		}
		public ManagedObjectReference ClusterNetworkPortGroup
		{
			get
			{
				return this._clusterNetworkPortGroup;
			}
			set
			{
				this._clusterNetworkPortGroup = value;
			}
		}
		public ManagedObjectReference Folder
		{
			get
			{
				return this._folder;
			}
			set
			{
				this._folder = value;
			}
		}
		public ManagedObjectReference ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
			set
			{
				this._resourcePool = value;
			}
		}
		public ServiceLocator ManagementVc
		{
			get
			{
				return this._managementVc;
			}
			set
			{
				this._managementVc = value;
			}
		}
		public string NodeName
		{
			get
			{
				return this._nodeName;
			}
			set
			{
				this._nodeName = value;
			}
		}
		public CustomizationIPSettings IpSettings
		{
			get
			{
				return this._ipSettings;
			}
			set
			{
				this._ipSettings = value;
			}
		}
		public NodeDeploymentSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
