namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualVideoCardOption : VirtualDeviceOption
	{
		protected LongOption _videoRamSizeInKB;
		protected IntOption _numDisplays;
		protected BoolOption _useAutoDetect;
		protected BoolOption _support3D;
		protected BoolOption _use3dRendererSupported;
		protected LongOption _graphicsMemorySizeInKB;
		protected BoolOption _graphicsMemorySizeSupported;
		public LongOption VideoRamSizeInKB
		{
			get
			{
				return this._videoRamSizeInKB;
			}
			set
			{
				this._videoRamSizeInKB = value;
			}
		}
		public IntOption NumDisplays
		{
			get
			{
				return this._numDisplays;
			}
			set
			{
				this._numDisplays = value;
			}
		}
		public BoolOption UseAutoDetect
		{
			get
			{
				return this._useAutoDetect;
			}
			set
			{
				this._useAutoDetect = value;
			}
		}
		public BoolOption Support3D
		{
			get
			{
				return this._support3D;
			}
			set
			{
				this._support3D = value;
			}
		}
		public BoolOption Use3dRendererSupported
		{
			get
			{
				return this._use3dRendererSupported;
			}
			set
			{
				this._use3dRendererSupported = value;
			}
		}
		public LongOption GraphicsMemorySizeInKB
		{
			get
			{
				return this._graphicsMemorySizeInKB;
			}
			set
			{
				this._graphicsMemorySizeInKB = value;
			}
		}
		public BoolOption GraphicsMemorySizeSupported
		{
			get
			{
				return this._graphicsMemorySizeSupported;
			}
			set
			{
				this._graphicsMemorySizeSupported = value;
			}
		}
	}
}
