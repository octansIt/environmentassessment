namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualPointingDeviceDeviceBackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected string _hostPointingDevice;
		public string HostPointingDevice
		{
			get
			{
				return this._hostPointingDevice;
			}
			set
			{
				this._hostPointingDevice = value;
			}
		}
	}
}
