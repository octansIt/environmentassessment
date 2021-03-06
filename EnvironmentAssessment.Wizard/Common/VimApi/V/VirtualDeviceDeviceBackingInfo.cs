namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceDeviceBackingInfo : VirtualDeviceBackingInfo
	{
		protected string _deviceName;
		protected bool? _useAutoDetect;
		public string DeviceName
		{
			get
			{
				return this._deviceName;
			}
			set
			{
				this._deviceName = value;
			}
		}
		public bool? UseAutoDetect
		{
			get
			{
				return this._useAutoDetect;
			}
			set
			{
				this._useAutoDetect = value;
			}
		}
	}
}
