namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDisk : VirtualDevice
	{
		protected long _capacityInKB;
		protected long? _capacityInBytes;
		protected SharesInfo _shares;
		protected StorageIOAllocationInfo _storageIOAllocation;
		protected string _diskObjectId;
		protected VirtualDiskVFlashCacheConfigInfo _vFlashCacheConfigInfo;
		public long CapacityInKB
		{
			get
			{
				return this._capacityInKB;
			}
			set
			{
				this._capacityInKB = value;
			}
		}
		public long? CapacityInBytes
		{
			get
			{
				return this._capacityInBytes;
			}
			set
			{
				this._capacityInBytes = value;
			}
		}
		public SharesInfo Shares
		{
			get
			{
				return this._shares;
			}
			set
			{
				this._shares = value;
			}
		}
		public StorageIOAllocationInfo StorageIOAllocation
		{
			get
			{
				return this._storageIOAllocation;
			}
			set
			{
				this._storageIOAllocation = value;
			}
		}
		public string DiskObjectId
		{
			get
			{
				return this._diskObjectId;
			}
			set
			{
				this._diskObjectId = value;
			}
		}
		public VirtualDiskVFlashCacheConfigInfo VFlashCacheConfigInfo
		{
			get
			{
				return this._vFlashCacheConfigInfo;
			}
			set
			{
				this._vFlashCacheConfigInfo = value;
			}
		}
	}
}
