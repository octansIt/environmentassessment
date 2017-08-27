namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskSparseVer1BackingOption : VirtualDeviceFileBackingOption
	{
		protected ChoiceOption _diskModes;
		protected BoolOption _split;
		protected BoolOption _writeThrough;
		protected bool _growable;
		public ChoiceOption DiskModes
		{
			get
			{
				return this._diskModes;
			}
			set
			{
				this._diskModes = value;
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
	}
}
