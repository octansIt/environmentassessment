namespace EnvironmentAssessment.Common.VimApi
{
	public class DeviceControllerNotSupported : DeviceNotSupported
	{
		protected string _controller;
		public string Controller
		{
			get
			{
				return this._controller;
			}
			set
			{
				this._controller = value;
			}
		}
	}
}
