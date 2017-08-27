namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskVFlashCacheConfigInfo : DynamicData
	{
		protected string _vFlashModule;
		protected long? _reservationInMB;
		protected string _cacheConsistencyType;
		protected string _cacheMode;
		protected long? _blockSizeInKB;
		public string VFlashModule
		{
			get
			{
				return this._vFlashModule;
			}
			set
			{
				this._vFlashModule = value;
			}
		}
		public long? ReservationInMB
		{
			get
			{
				return this._reservationInMB;
			}
			set
			{
				this._reservationInMB = value;
			}
		}
		public string CacheConsistencyType
		{
			get
			{
				return this._cacheConsistencyType;
			}
			set
			{
				this._cacheConsistencyType = value;
			}
		}
		public string CacheMode
		{
			get
			{
				return this._cacheMode;
			}
			set
			{
				this._cacheMode = value;
			}
		}
		public long? BlockSizeInKB
		{
			get
			{
				return this._blockSizeInKB;
			}
			set
			{
				this._blockSizeInKB = value;
			}
		}
	}
}
