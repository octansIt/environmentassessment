namespace EnvironmentAssessment.Common.VimApi
{
	public class HostStorageDeviceInfo : DynamicData
	{
		protected HostHostBusAdapter[] _hostBusAdapter;
		protected ScsiLun[] _scsiLun;
		protected HostScsiTopology _scsiTopology;
		protected HostMultipathInfo _multipathInfo;
		protected HostPlugStoreTopology _plugStoreTopology;
		protected bool _softwareInternetScsiEnabled;
		public HostHostBusAdapter[] HostBusAdapter
		{
			get
			{
				return this._hostBusAdapter;
			}
			set
			{
				this._hostBusAdapter = value;
			}
		}
		public ScsiLun[] ScsiLun
		{
			get
			{
				return this._scsiLun;
			}
			set
			{
				this._scsiLun = value;
			}
		}
		public HostScsiTopology ScsiTopology
		{
			get
			{
				return this._scsiTopology;
			}
			set
			{
				this._scsiTopology = value;
			}
		}
		public HostMultipathInfo MultipathInfo
		{
			get
			{
				return this._multipathInfo;
			}
			set
			{
				this._multipathInfo = value;
			}
		}
		public HostPlugStoreTopology PlugStoreTopology
		{
			get
			{
				return this._plugStoreTopology;
			}
			set
			{
				this._plugStoreTopology = value;
			}
		}
		public bool SoftwareInternetScsiEnabled
		{
			get
			{
				return this._softwareInternetScsiEnabled;
			}
			set
			{
				this._softwareInternetScsiEnabled = value;
			}
		}
	}
}
