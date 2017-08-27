namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLocalFileSystemVolumeSpec : DynamicData
	{
		protected string _device;
		protected string _localPath;
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string LocalPath
		{
			get
			{
				return this._localPath;
			}
			set
			{
				this._localPath = value;
			}
		}
	}
}
