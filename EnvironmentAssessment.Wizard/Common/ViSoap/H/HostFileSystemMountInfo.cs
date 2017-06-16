namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFileSystemMountInfo : DynamicData
	{
		protected HostMountInfo _mountInfo;
		protected HostFileSystemVolume _volume;
		protected string _vStorageSupport;
		public HostMountInfo MountInfo
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
		public HostFileSystemVolume Volume
		{
			get
			{
				return this._volume;
			}
			set
			{
				this._volume = value;
			}
		}
		public string VStorageSupport
		{
			get
			{
				return this._vStorageSupport;
			}
			set
			{
				this._vStorageSupport = value;
			}
		}
	}
}
