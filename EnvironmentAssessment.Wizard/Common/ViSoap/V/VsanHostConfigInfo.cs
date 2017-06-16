namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanHostConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected ManagedObjectReference _hostSystem;
		protected VsanHostConfigInfoClusterInfo _clusterInfo;
		protected VsanHostConfigInfoStorageInfo _storageInfo;
		protected VsanHostConfigInfoNetworkInfo _networkInfo;
		protected VsanHostFaultDomainInfo _faultDomainInfo;
		protected VsanHostConfigInfo_LinkedView _linkedView;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
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
		public VsanHostConfigInfoClusterInfo ClusterInfo
		{
			get
			{
				return this._clusterInfo;
			}
			set
			{
				this._clusterInfo = value;
			}
		}
		public VsanHostConfigInfoStorageInfo StorageInfo
		{
			get
			{
				return this._storageInfo;
			}
			set
			{
				this._storageInfo = value;
			}
		}
		public VsanHostConfigInfoNetworkInfo NetworkInfo
		{
			get
			{
				return this._networkInfo;
			}
			set
			{
				this._networkInfo = value;
			}
		}
		public VsanHostFaultDomainInfo FaultDomainInfo
		{
			get
			{
				return this._faultDomainInfo;
			}
			set
			{
				this._faultDomainInfo = value;
			}
		}
		public VsanHostConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
