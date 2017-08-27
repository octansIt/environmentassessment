namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualUSBXHCIControllerOption : VirtualControllerOption
	{
		protected BoolOption _autoConnectDevices;
		protected string[] _supportedSpeeds;
		public BoolOption AutoConnectDevices
		{
			get
			{
				return this._autoConnectDevices;
			}
			set
			{
				this._autoConnectDevices = value;
			}
		}
		public string[] SupportedSpeeds
		{
			get
			{
				return this._supportedSpeeds;
			}
			set
			{
				this._supportedSpeeds = value;
			}
		}
	}
}
