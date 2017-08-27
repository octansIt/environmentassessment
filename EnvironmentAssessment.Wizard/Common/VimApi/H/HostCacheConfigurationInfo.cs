namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCacheConfigurationInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected long _swapSize;
		protected HostCacheConfigurationInfo_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public long SwapSize
		{
			get
			{
				return this._swapSize;
			}
			set
			{
				this._swapSize = value;
			}
		}
		public HostCacheConfigurationInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
