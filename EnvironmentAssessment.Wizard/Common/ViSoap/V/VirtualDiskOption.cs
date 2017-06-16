namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskOption : VirtualDeviceOption
	{
		protected LongOption _capacityInKB;
		protected StorageIOAllocationOption _ioAllocationOption;
		protected VirtualDiskOptionVFlashCacheConfigOption _vFlashCacheConfigOption;
		public LongOption CapacityInKB
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
		public StorageIOAllocationOption IoAllocationOption
		{
			get
			{
				return this._ioAllocationOption;
			}
			set
			{
				this._ioAllocationOption = value;
			}
		}
		public VirtualDiskOptionVFlashCacheConfigOption VFlashCacheConfigOption
		{
			get
			{
				return this._vFlashCacheConfigOption;
			}
			set
			{
				this._vFlashCacheConfigOption = value;
			}
		}
	}
}
