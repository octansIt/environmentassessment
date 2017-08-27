namespace EnvironmentAssessment.Common.VimApi
{
	public class HostGraphicsConfigDeviceType : DynamicData
	{
		protected string _deviceId;
		protected string _graphicsType;
		public string DeviceId
		{
			get
			{
				return this._deviceId;
			}
			set
			{
				this._deviceId = value;
			}
		}
		public string GraphicsType
		{
			get
			{
				return this._graphicsType;
			}
			set
			{
				this._graphicsType = value;
			}
		}
	}
}
