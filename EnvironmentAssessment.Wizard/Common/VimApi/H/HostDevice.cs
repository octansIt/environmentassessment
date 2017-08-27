namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDevice : DynamicData
	{
		protected string _deviceName;
		protected string _deviceType;
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
		public string DeviceType
		{
			get
			{
				return this._deviceType;
			}
			set
			{
				this._deviceType = value;
			}
		}
	}
}
