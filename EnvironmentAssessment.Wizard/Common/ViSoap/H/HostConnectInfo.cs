namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConnectInfo : DynamicData
	{
		protected string _serverIp;
		protected bool? _inDasCluster;
		protected HostListSummary _host;
		protected VirtualMachineSummary[] _vm;
		protected bool? _vimAccountNameRequired;
		protected bool? _clusterSupported;
		protected HostConnectInfoNetworkInfo[] _network;
		protected HostDatastoreConnectInfo[] _datastore;
		protected HostLicenseConnectInfo _license;
		public string ServerIp
		{
			get
			{
				return this._serverIp;
			}
			set
			{
				this._serverIp = value;
			}
		}
		public bool? InDasCluster
		{
			get
			{
				return this._inDasCluster;
			}
			set
			{
				this._inDasCluster = value;
			}
		}
		public HostListSummary Host
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
		public VirtualMachineSummary[] Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public bool? VimAccountNameRequired
		{
			get
			{
				return this._vimAccountNameRequired;
			}
			set
			{
				this._vimAccountNameRequired = value;
			}
		}
		public bool? ClusterSupported
		{
			get
			{
				return this._clusterSupported;
			}
			set
			{
				this._clusterSupported = value;
			}
		}
		public HostConnectInfoNetworkInfo[] Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public HostDatastoreConnectInfo[] Datastore
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
		public HostLicenseConnectInfo License
		{
			get
			{
				return this._license;
			}
			set
			{
				this._license = value;
			}
		}
	}
}
