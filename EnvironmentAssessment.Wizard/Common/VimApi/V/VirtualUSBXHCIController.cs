namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualUSBXHCIController : VirtualController
	{
		protected bool? _autoConnectDevices;
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
	}
}
