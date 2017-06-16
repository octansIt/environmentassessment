namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualControllerOption : VirtualDeviceOption
	{
		protected IntOption _devices;
		protected string[] _supportedDevice;
		public IntOption Devices
		{
			get
			{
				return this._devices;
			}
			set
			{
				this._devices = value;
			}
		}
		public string[] SupportedDevice
		{
			get
			{
				return this._supportedDevice;
			}
			set
			{
				this._supportedDevice = value;
			}
		}
	}
}
