namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskSparseVer2BackingOption : VirtualDeviceFileBackingOption
	{
		protected ChoiceOption _diskMode;
		protected BoolOption _split;
		protected BoolOption _writeThrough;
		protected bool _growable;
		protected bool _hotGrowable;
		protected bool _uuid;
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
	}
}
