namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskSeSparseBackingInfo : VirtualDeviceFileBackingInfo
	{
		protected string _diskMode;
		protected bool? _writeThrough;
		protected string _uuid;
		protected string _contentId;
		protected string _changeId;
		protected VirtualDiskSeSparseBackingInfo _parent;
		protected string _deltaDiskFormat;
		protected bool? _digestEnabled;
		protected int? _grainSize;
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
		public VirtualDiskSeSparseBackingInfo Parent
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
		public int? GrainSize
		{
			get
			{
				return this._grainSize;
			}
			set
			{
				this._grainSize = value;
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
		public new VirtualDiskSeSparseBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualDiskSeSparseBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
