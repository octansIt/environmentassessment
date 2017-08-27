namespace EnvironmentAssessment.Common.VimApi
{
	public class NodeDeploymentSpec_LinkedView
	{
		protected HostSystem _esxHost;
		protected Datastore _datastore;
		protected Network _publicNetworkPortGroup;
		protected Network _clusterNetworkPortGroup;
		protected Folder _folder;
		protected ResourcePool _resourcePool;
		public HostSystem EsxHost
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
		public Datastore Datastore
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
		public Network PublicNetworkPortGroup
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
		public Network ClusterNetworkPortGroup
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
		public Folder Folder
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
		public ResourcePool ResourcePool
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
	}
}
