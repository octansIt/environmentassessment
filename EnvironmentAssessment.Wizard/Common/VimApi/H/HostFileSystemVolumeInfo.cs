namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFileSystemVolumeInfo : DynamicData
	{
		protected string[] _volumeTypeList;
		protected HostFileSystemMountInfo[] _mountInfo;
		public string[] VolumeTypeList
		{
			get
			{
				return this._volumeTypeList;
			}
			set
			{
				this._volumeTypeList = value;
			}
		}
		public HostFileSystemMountInfo[] MountInfo
		{
			get
			{
				return this._mountInfo;
			}
			set
			{
				this._mountInfo = value;
			}
		}
	}
}
