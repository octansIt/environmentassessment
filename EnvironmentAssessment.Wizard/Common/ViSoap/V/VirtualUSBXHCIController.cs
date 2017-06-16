namespace EnvironmentAssessment.Common.VISoap
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
