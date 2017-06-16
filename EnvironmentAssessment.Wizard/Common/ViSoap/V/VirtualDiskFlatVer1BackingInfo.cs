namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskFlatVer1BackingInfo : VirtualDeviceFileBackingInfo
	{
		protected string _diskMode;
		protected bool? _split;
		protected bool? _writeThrough;
		protected string _contentId;
		protected VirtualDiskFlatVer1BackingInfo _parent;
		public string DiskMode
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
		public bool? Split
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
		public bool? WriteThrough
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
		public string ContentId
		{
			get
			{
				return this._contentId;
			}
			set
			{
				this._contentId = value;
			}
		}
		public VirtualDiskFlatVer1BackingInfo Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
		public new VirtualDiskFlatVer1BackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualDiskFlatVer1BackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
