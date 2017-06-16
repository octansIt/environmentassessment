namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualUSBControllerOption : VirtualControllerOption
	{
		protected BoolOption _autoConnectDevices;
		protected BoolOption _ehciSupported;
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
		public BoolOption EhciSupported
		{
			get
			{
				return this._ehciSupported;
			}
			set
			{
				this._ehciSupported = value;
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
