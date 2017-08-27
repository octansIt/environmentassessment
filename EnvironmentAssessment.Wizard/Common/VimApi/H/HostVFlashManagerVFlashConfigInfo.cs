namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashConfigInfo : DynamicData
	{
		protected HostVFlashManagerVFlashResourceConfigInfo _vFlashResourceConfigInfo;
		protected HostVFlashManagerVFlashCacheConfigInfo _vFlashCacheConfigInfo;
		public HostVFlashManagerVFlashResourceConfigInfo VFlashResourceConfigInfo
		{
			get
			{
				return this._vFlashResourceConfigInfo;
			}
			set
			{
				this._vFlashResourceConfigInfo = value;
			}
		}
		public HostVFlashManagerVFlashCacheConfigInfo VFlashCacheConfigInfo
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
