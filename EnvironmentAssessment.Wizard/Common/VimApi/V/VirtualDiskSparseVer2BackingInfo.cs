namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskSparseVer2BackingInfo : VirtualDeviceFileBackingInfo
	{
		protected string _diskMode;
		protected bool? _split;
		protected bool? _writeThrough;
		protected long? _spaceUsedInKB;
		protected string _uuid;
		protected string _contentId;
		protected string _changeId;
		protected VirtualDiskSparseVer2BackingInfo _parent;
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
		public long? SpaceUsedInKB
		{
			get
			{
				return this._spaceUsedInKB;
			}
			set
			{
				this._spaceUsedInKB = value;
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
		public VirtualDiskSparseVer2BackingInfo Parent
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
		public new VirtualDiskSparseVer2BackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualDiskSparseVer2BackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
