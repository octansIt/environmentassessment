namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVmfsSpec : DynamicData
	{
		protected HostScsiDiskPartition _extent;
		protected int? _blockSizeMb;
		protected int _majorVersion;
		protected string _volumeName;
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
	}
}
