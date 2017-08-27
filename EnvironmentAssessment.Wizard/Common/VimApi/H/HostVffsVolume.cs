namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVffsVolume : HostFileSystemVolume
	{
		protected int _majorVersion;
		protected string _version;
		protected string _uuid;
		protected HostScsiDiskPartition[] _extent;
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
	}
}
