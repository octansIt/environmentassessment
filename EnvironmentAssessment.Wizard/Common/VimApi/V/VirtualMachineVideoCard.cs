namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineVideoCard : VirtualDevice
	{
		protected long? _videoRamSizeInKB;
		protected int? _numDisplays;
		protected bool? _useAutoDetect;
		protected bool? _enable3DSupport;
		protected string _use3dRenderer;
		protected long? _graphicsMemorySizeInKB;
		public long? VideoRamSizeInKB
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
		public int? NumDisplays
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
		public bool? UseAutoDetect
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
		public bool? Enable3DSupport
		{
			get
			{
				return this._enable3DSupport;
			}
			set
			{
				this._enable3DSupport = value;
			}
		}
		public string Use3dRenderer
		{
			get
			{
				return this._use3dRenderer;
			}
			set
			{
				this._use3dRenderer = value;
			}
		}
		public long? GraphicsMemorySizeInKB
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
	}
}
