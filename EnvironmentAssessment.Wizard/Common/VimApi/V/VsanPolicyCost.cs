namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanPolicyCost : DynamicData
	{
		protected long? _changeDataSize;
		protected long? _currentDataSize;
		protected long? _tempDataSize;
		protected long? _copyDataSize;
		protected long? _changeFlashReadCacheSize;
		protected long? _currentFlashReadCacheSize;
		protected float? _currentDiskSpaceToAddressSpaceRatio;
		protected float? _diskSpaceToAddressSpaceRatio;
		public long? ChangeDataSize
		{
			get
			{
				return this._changeDataSize;
			}
			set
			{
				this._changeDataSize = value;
			}
		}
		public long? CurrentDataSize
		{
			get
			{
				return this._currentDataSize;
			}
			set
			{
				this._currentDataSize = value;
			}
		}
		public long? TempDataSize
		{
			get
			{
				return this._tempDataSize;
			}
			set
			{
				this._tempDataSize = value;
			}
		}
		public long? CopyDataSize
		{
			get
			{
				return this._copyDataSize;
			}
			set
			{
				this._copyDataSize = value;
			}
		}
		public long? ChangeFlashReadCacheSize
		{
			get
			{
				return this._changeFlashReadCacheSize;
			}
			set
			{
				this._changeFlashReadCacheSize = value;
			}
		}
		public long? CurrentFlashReadCacheSize
		{
			get
			{
				return this._currentFlashReadCacheSize;
			}
			set
			{
				this._currentFlashReadCacheSize = value;
			}
		}
		public float? CurrentDiskSpaceToAddressSpaceRatio
		{
			get
			{
				return this._currentDiskSpaceToAddressSpaceRatio;
			}
			set
			{
				this._currentDiskSpaceToAddressSpaceRatio = value;
			}
		}
		public float? DiskSpaceToAddressSpaceRatio
		{
			get
			{
				return this._diskSpaceToAddressSpaceRatio;
			}
			set
			{
				this._diskSpaceToAddressSpaceRatio = value;
			}
		}
	}
}
