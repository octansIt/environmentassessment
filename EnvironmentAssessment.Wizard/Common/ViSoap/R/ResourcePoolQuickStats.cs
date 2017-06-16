namespace EnvironmentAssessment.Common.VISoap
{
    public class ResourcePoolQuickStats : DynamicData
	{
		protected long? _overallCpuUsage;
		protected long? _overallCpuDemand;
		protected long? _guestMemoryUsage;
		protected long? _hostMemoryUsage;
		protected long? _distributedCpuEntitlement;
		protected long? _distributedMemoryEntitlement;
		protected int? _staticCpuEntitlement;
		protected int? _staticMemoryEntitlement;
		protected long? _privateMemory;
		protected long? _sharedMemory;
		protected long? _swappedMemory;
		protected long? _balloonedMemory;
		protected long? _overheadMemory;
		protected long? _consumedOverheadMemory;
		protected long? _compressedMemory;
		public long? OverallCpuUsage
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
		public long? OverallCpuDemand
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
		public long? GuestMemoryUsage
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
		public long? HostMemoryUsage
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
		public long? DistributedCpuEntitlement
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
		public long? DistributedMemoryEntitlement
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
		public long? PrivateMemory
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
		public long? SharedMemory
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
		public long? SwappedMemory
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
		public long? BalloonedMemory
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
		public long? OverheadMemory
		{
			get
			{
				return this._overheadMemory;
			}
			set
			{
				this._overheadMemory = value;
			}
		}
		public long? ConsumedOverheadMemory
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
	}
}
