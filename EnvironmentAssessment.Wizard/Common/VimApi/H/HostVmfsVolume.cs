namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVmfsVolume : HostFileSystemVolume
	{
		protected int _blockSizeMb;
		protected int? _blockSize;
		protected int? _unmapGranularity;
		protected string _unmapPriority;
		protected int _maxBlocks;
		protected int _majorVersion;
		protected string _version;
		protected string _uuid;
		protected HostScsiDiskPartition[] _extent;
		protected bool _vmfsUpgradable;
		protected HostForceMountedInfo _forceMountedInfo;
		protected bool? _ssd;
		protected bool? _local;
		protected string _scsiDiskType;
		public int BlockSizeMb
		{
			get
			{
				return this._blockSizeMb;
			}
			set
			{
				this._blockSizeMb = value;
			}
		}
		public int? BlockSize
		{
			get
			{
				return this._blockSize;
			}
			set
			{
				this._blockSize = value;
			}
		}
		public int? UnmapGranularity
		{
			get
			{
				return this._unmapGranularity;
			}
			set
			{
				this._unmapGranularity = value;
			}
		}
		public string UnmapPriority
		{
			get
			{
				return this._unmapPriority;
			}
			set
			{
				this._unmapPriority = value;
			}
		}
		public int MaxBlocks
		{
			get
			{
				return this._maxBlocks;
			}
			set
			{
				this._maxBlocks = value;
			}
		}
		public int MajorVersion
		{
			get
			{
				return this._majorVersion;
			}
			set
			{
				this._majorVersion = value;
			}
		}
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
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
		public HostScsiDiskPartition[] Extent
		{
			get
			{
				return this._extent;
			}
			set
			{
				this._extent = value;
			}
		}
		public bool VmfsUpgradable
		{
			get
			{
				return this._vmfsUpgradable;
			}
			set
			{
				this._vmfsUpgradable = value;
			}
		}
		public HostForceMountedInfo ForceMountedInfo
		{
			get
			{
				return this._forceMountedInfo;
			}
			set
			{
				this._forceMountedInfo = value;
			}
		}
		public bool? Ssd
		{
			get
			{
				return this._ssd;
			}
			set
			{
				this._ssd = value;
			}
		}
		public bool? Local
		{
			get
			{
				return this._local;
			}
			set
			{
				this._local = value;
			}
		}
		public string ScsiDiskType
		{
			get
			{
				return this._scsiDiskType;
			}
			set
			{
				this._scsiDiskType = value;
			}
		}
	}
}
