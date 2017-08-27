namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualSwitchSimpleBridge : HostVirtualSwitchBridge
	{
		protected string _nicDevice;
		public string NicDevice
		{
			get
			{
				return this._nicDevice;
			}
			set
			{
				this._nicDevice = value;
			}
		}
	}
}
