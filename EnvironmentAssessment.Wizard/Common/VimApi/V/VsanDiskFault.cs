namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanDiskFault : VsanFault
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
