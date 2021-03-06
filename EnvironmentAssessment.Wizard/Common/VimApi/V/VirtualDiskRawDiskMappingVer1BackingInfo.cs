namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskRawDiskMappingVer1BackingInfo : VirtualDeviceFileBackingInfo
	{
		protected string _lunUuid;
		protected string _deviceName;
		protected string _compatibilityMode;
		protected string _diskMode;
		protected string _uuid;
		protected string _contentId;
		protected string _changeId;
		protected VirtualDiskRawDiskMappingVer1BackingInfo _parent;
		protected string _sharing;
		public string LunUuid
		{
			get
			{
				return this._lunUuid;
			}
			set
			{
				this._lunUuid = value;
			}
		}
		public string DeviceName
		{
			get
			{
				return this._deviceName;
			}
			set
			{
				this._deviceName = value;
			}
		}
		public string CompatibilityMode
		{
			get
			{
				return this._compatibilityMode;
			}
			set
			{
				this._compatibilityMode = value;
			}
		}
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
		public VirtualDiskRawDiskMappingVer1BackingInfo Parent
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
		public new VirtualDiskRawDiskMappingVer1BackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualDiskRawDiskMappingVer1BackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
