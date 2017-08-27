namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualPointingDeviceBackingOption : VirtualDeviceDeviceBackingOption
	{
		protected ChoiceOption _hostPointingDevice;
		public ChoiceOption HostPointingDevice
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
