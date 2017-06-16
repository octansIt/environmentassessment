namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualUSBController : VirtualController
	{
		protected bool? _autoConnectDevices;
		protected bool? _ehciEnabled;
		public bool? AutoConnectDevices
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
		public bool? EhciEnabled
		{
			get
			{
				return this._ehciEnabled;
			}
			set
			{
				this._ehciEnabled = value;
			}
		}
	}
}
