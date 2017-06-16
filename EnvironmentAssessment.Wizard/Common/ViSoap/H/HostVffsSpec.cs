namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVffsSpec : DynamicData
	{
		protected string _devicePath;
		protected HostDiskPartitionSpec _partition;
		protected int _majorVersion;
		protected string _volumeName;
		public string DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
		public HostDiskPartitionSpec Partition
		{
			get
			{
				return this._partition;
			}
			set
			{
				this._partition = value;
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
