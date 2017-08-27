namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLocalFileSystemVolume : HostFileSystemVolume
	{
		protected string _device;
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
	}
}
