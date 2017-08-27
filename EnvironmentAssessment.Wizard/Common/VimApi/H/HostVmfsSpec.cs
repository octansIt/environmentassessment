namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVmfsSpec : DynamicData
	{
		protected HostScsiDiskPartition _extent;
		protected int? _blockSizeMb;
		protected int _majorVersion;
		protected string _volumeName;
		protected int? _blockSize;
		protected int? _unmapGranularity;
		protected string _unmapPriority;
		public HostScsiDiskPartition Extent
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
		public int? BlockSizeMb
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
		public string VolumeName
		{
			get
			{
				return this._volumeName;
			}
			set
			{
				this._volumeName = value;
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
	}
}
