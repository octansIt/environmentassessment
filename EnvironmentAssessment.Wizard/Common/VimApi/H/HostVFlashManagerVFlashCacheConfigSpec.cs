namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashCacheConfigSpec : DynamicData
	{
		protected string _defaultVFlashModule;
		protected long _swapCacheReservationInGB;
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
		public long SwapCacheReservationInGB
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
