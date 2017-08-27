namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption : DynamicData
	{
		protected string _vFlashModule;
		protected string _vFlashModuleVersion;
		protected string _minSupportedModuleVersion;
		protected ChoiceOption _cacheConsistencyType;
		protected ChoiceOption _cacheMode;
		protected LongOption _blockSizeInKBOption;
		protected LongOption _reservationInMBOption;
		protected long _maxDiskSizeInKB;
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
		public string VFlashModuleVersion
		{
			get
			{
				return this._vFlashModuleVersion;
			}
			set
			{
				this._vFlashModuleVersion = value;
			}
		}
		public string MinSupportedModuleVersion
		{
			get
			{
				return this._minSupportedModuleVersion;
			}
			set
			{
				this._minSupportedModuleVersion = value;
			}
		}
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
		public LongOption BlockSizeInKBOption
		{
			get
			{
				return this._blockSizeInKBOption;
			}
			set
			{
				this._blockSizeInKBOption = value;
			}
		}
		public LongOption ReservationInMBOption
		{
			get
			{
				return this._reservationInMBOption;
			}
			set
			{
				this._reservationInMBOption = value;
			}
		}
		public long MaxDiskSizeInKB
		{
			get
			{
				return this._maxDiskSizeInKB;
			}
			set
			{
				this._maxDiskSizeInKB = value;
			}
		}
	}
}
