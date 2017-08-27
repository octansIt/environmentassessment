namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashCacheConfigInfo : DynamicData
	{
		protected HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption[] _vFlashModuleConfigOption;
		protected string _defaultVFlashModule;
		protected long? _swapCacheReservationInGB;
		public HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption[] VFlashModuleConfigOption
		{
			get
			{
				return this._vFlashModuleConfigOption;
			}
			set
			{
				this._vFlashModuleConfigOption = value;
			}
		}
		public string DefaultVFlashModule
		{
			get
			{
				return this._defaultVFlashModule;
			}
			set
			{
				this._defaultVFlashModule = value;
			}
		}
		public long? SwapCacheReservationInGB
		{
			get
			{
				return this._swapCacheReservationInGB;
			}
			set
			{
				this._swapCacheReservationInGB = value;
			}
		}
	}
}
