namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskFlatVer2BackingOption : VirtualDeviceFileBackingOption
	{
		protected ChoiceOption _diskMode;
		protected BoolOption _split;
		protected BoolOption _writeThrough;
		protected bool _growable;
		protected bool _hotGrowable;
		protected bool _uuid;
		protected BoolOption _thinProvisioned;
		protected BoolOption _eagerlyScrub;
		protected ChoiceOption _deltaDiskFormat;
		protected VirtualDiskDeltaDiskFormatsSupported[] _deltaDiskFormatsSupported;
		public ChoiceOption DiskMode
		{
			get
			{
				return this._diskMode;
			}
			set
			{
				this._diskMode = value;
			}
		}
		public BoolOption Split
		{
			get
			{
				return this._split;
			}
			set
			{
				this._split = value;
			}
		}
		public BoolOption WriteThrough
		{
			get
			{
				return this._writeThrough;
			}
			set
			{
				this._writeThrough = value;
			}
		}
		public bool Growable
		{
			get
			{
				return this._growable;
			}
			set
			{
				this._growable = value;
			}
		}
		public bool HotGrowable
		{
			get
			{
				return this._hotGrowable;
			}
			set
			{
				this._hotGrowable = value;
			}
		}
		public bool Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public BoolOption ThinProvisioned
		{
			get
			{
				return this._thinProvisioned;
			}
			set
			{
				this._thinProvisioned = value;
			}
		}
		public BoolOption EagerlyScrub
		{
			get
			{
				return this._eagerlyScrub;
			}
			set
			{
				this._eagerlyScrub = value;
			}
		}
		public ChoiceOption DeltaDiskFormat
		{
			get
			{
				return this._deltaDiskFormat;
			}
			set
			{
				this._deltaDiskFormat = value;
			}
		}
		public VirtualDiskDeltaDiskFormatsSupported[] DeltaDiskFormatsSupported
		{
			get
			{
				return this._deltaDiskFormatsSupported;
			}
			set
			{
				this._deltaDiskFormatsSupported = value;
			}
		}
	}
}
