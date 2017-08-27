namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskOptionVFlashCacheConfigOption : DynamicData
	{
		protected ChoiceOption _cacheConsistencyType;
		protected ChoiceOption _cacheMode;
		protected LongOption _reservationInMB;
		protected LongOption _blockSizeInKB;
		public ChoiceOption CacheConsistencyType
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
		public ChoiceOption CacheMode
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
		public LongOption ReservationInMB
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
		public LongOption BlockSizeInKB
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
