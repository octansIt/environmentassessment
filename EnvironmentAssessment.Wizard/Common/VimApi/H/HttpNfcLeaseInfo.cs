namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLeaseInfo : DynamicData
	{
		protected ManagedObjectReference _lease;
		protected ManagedObjectReference _entity;
		protected HttpNfcLeaseDeviceUrl[] _deviceUrl;
		protected long _totalDiskCapacityInKB;
		protected int _leaseTimeout;
		protected HttpNfcLeaseDatastoreLeaseInfo[] _hostMap;
		protected HttpNfcLeaseInfo_LinkedView _linkedView;
		public ManagedObjectReference Lease
		{
			get
			{
				return this._lease;
			}
			set
			{
				this._lease = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public HttpNfcLeaseDeviceUrl[] DeviceUrl
		{
			get
			{
				return this._deviceUrl;
			}
			set
			{
				this._deviceUrl = value;
			}
		}
		public long TotalDiskCapacityInKB
		{
			get
			{
				return this._totalDiskCapacityInKB;
			}
			set
			{
				this._totalDiskCapacityInKB = value;
			}
		}
		public int LeaseTimeout
		{
			get
			{
				return this._leaseTimeout;
			}
			set
			{
				this._leaseTimeout = value;
			}
		}
		public HttpNfcLeaseDatastoreLeaseInfo[] HostMap
		{
			get
			{
				return this._hostMap;
			}
			set
			{
				this._hostMap = value;
			}
		}
		public HttpNfcLeaseInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
