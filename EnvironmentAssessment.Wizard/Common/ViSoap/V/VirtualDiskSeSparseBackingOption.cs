namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskSeSparseBackingOption : VirtualDeviceFileBackingOption
	{
		protected ChoiceOption _diskMode;
		protected BoolOption _writeThrough;
		protected bool _growable;
		protected bool _hotGrowable;
		protected bool _uuid;
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
