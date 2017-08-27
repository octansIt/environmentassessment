namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskFlatVer2BackingInfo : VirtualDeviceFileBackingInfo
	{
		protected string _diskMode;
		protected bool? _split;
		protected bool? _writeThrough;
		protected bool? _thinProvisioned;
		protected bool? _eagerlyScrub;
		protected string _uuid;
		protected string _contentId;
		protected string _changeId;
		protected VirtualDiskFlatVer2BackingInfo _parent;
		protected string _deltaDiskFormat;
		protected bool? _digestEnabled;
		protected int? _deltaGrainSize;
		protected string _deltaDiskFormatVariant;
		protected string _sharing;
		protected CryptoKeyId _keyId;
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
		public bool? ThinProvisioned
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
		public bool? EagerlyScrub
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
		public string Uuid
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
		public string ChangeId
		{
			get
			{
				return this._changeId;
			}
			set
			{
				this._changeId = value;
			}
		}
		public VirtualDiskFlatVer2BackingInfo Parent
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
		public string DeltaDiskFormat
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
		public bool? DigestEnabled
		{
			get
			{
				return this._digestEnabled;
			}
			set
			{
				this._digestEnabled = value;
			}
		}
		public int? DeltaGrainSize
		{
			get
			{
				return this._deltaGrainSize;
			}
			set
			{
				this._deltaGrainSize = value;
			}
		}
		public string DeltaDiskFormatVariant
		{
			get
			{
				return this._deltaDiskFormatVariant;
			}
			set
			{
				this._deltaDiskFormatVariant = value;
			}
		}
		public string Sharing
		{
			get
			{
				return this._sharing;
			}
			set
			{
				this._sharing = value;
			}
		}
		public CryptoKeyId KeyId
		{
			get
			{
				return this._keyId;
			}
			set
			{
				this._keyId = value;
			}
		}
		public new VirtualDiskFlatVer2BackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualDiskFlatVer2BackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
