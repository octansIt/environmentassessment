namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineQuickStats : DynamicData
	{
		protected int? _overallCpuUsage;
		protected int? _overallCpuDemand;
		protected int? _guestMemoryUsage;
		protected int? _hostMemoryUsage;
		protected ManagedEntityStatus _guestHeartbeatStatus;
		protected int? _distributedCpuEntitlement;
		protected int? _distributedMemoryEntitlement;
		protected int? _staticCpuEntitlement;
		protected int? _staticMemoryEntitlement;
		protected int? _privateMemory;
		protected int? _sharedMemory;
		protected int? _swappedMemory;
		protected int? _balloonedMemory;
		protected int? _consumedOverheadMemory;
		protected int? _ftLogBandwidth;
		protected int? _ftSecondaryLatency;
		protected ManagedEntityStatus? _ftLatencyStatus;
		protected long? _compressedMemory;
		protected int? _uptimeSeconds;
		protected long? _ssdSwappedMemory;
		public int? OverallCpuUsage
		{
			get
			{
				return this._overallCpuUsage;
			}
			set
			{
				this._overallCpuUsage = value;
			}
		}
		public int? OverallCpuDemand
		{
			get
			{
				return this._overallCpuDemand;
			}
			set
			{
				this._overallCpuDemand = value;
			}
		}
		public int? GuestMemoryUsage
		{
			get
			{
				return this._guestMemoryUsage;
			}
			set
			{
				this._guestMemoryUsage = value;
			}
		}
		public int? HostMemoryUsage
		{
			get
			{
				return this._hostMemoryUsage;
			}
			set
			{
				this._hostMemoryUsage = value;
			}
		}
		public ManagedEntityStatus GuestHeartbeatStatus
		{
			get
			{
				return this._guestHeartbeatStatus;
			}
			set
			{
				this._guestHeartbeatStatus = value;
			}
		}
		public int? DistributedCpuEntitlement
		{
			get
			{
				return this._distributedCpuEntitlement;
			}
			set
			{
				this._distributedCpuEntitlement = value;
			}
		}
		public int? DistributedMemoryEntitlement
		{
			get
			{
				return this._distributedMemoryEntitlement;
			}
			set
			{
				this._distributedMemoryEntitlement = value;
			}
		}
		public int? StaticCpuEntitlement
		{
			get
			{
				return this._staticCpuEntitlement;
			}
			set
			{
				this._staticCpuEntitlement = value;
			}
		}
		public int? StaticMemoryEntitlement
		{
			get
			{
				return this._staticMemoryEntitlement;
			}
			set
			{
				this._staticMemoryEntitlement = value;
			}
		}
		public int? PrivateMemory
		{
			get
			{
				return this._privateMemory;
			}
			set
			{
				this._privateMemory = value;
			}
		}
		public int? SharedMemory
		{
			get
			{
				return this._sharedMemory;
			}
			set
			{
				this._sharedMemory = value;
			}
		}
		public int? SwappedMemory
		{
			get
			{
				return this._swappedMemory;
			}
			set
			{
				this._swappedMemory = value;
			}
		}
		public int? BalloonedMemory
		{
			get
			{
				return this._balloonedMemory;
			}
			set
			{
				this._balloonedMemory = value;
			}
		}
		public int? ConsumedOverheadMemory
		{
			get
			{
				return this._consumedOverheadMemory;
			}
			set
			{
				this._consumedOverheadMemory = value;
			}
		}
		public int? FtLogBandwidth
		{
			get
			{
				return this._ftLogBandwidth;
			}
			set
			{
				this._ftLogBandwidth = value;
			}
		}
		public int? FtSecondaryLatency
		{
			get
			{
				return this._ftSecondaryLatency;
			}
			set
			{
				this._ftSecondaryLatency = value;
			}
		}
		public ManagedEntityStatus? FtLatencyStatus
		{
			get
			{
				return this._ftLatencyStatus;
			}
			set
			{
				this._ftLatencyStatus = value;
			}
		}
		public long? CompressedMemory
		{
			get
			{
				return this._compressedMemory;
			}
			set
			{
				this._compressedMemory = value;
			}
		}
		public int? UptimeSeconds
		{
			get
			{
				return this._uptimeSeconds;
			}
			set
			{
				this._uptimeSeconds = value;
			}
		}
		public long? SsdSwappedMemory
		{
			get
			{
				return this._ssdSwappedMemory;
			}
			set
			{
				this._ssdSwappedMemory = value;
			}
		}
	}
}
