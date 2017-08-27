namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnsupportedDeviceBackingInfo : OvfSystemFault
	{
		protected string _elementName;
		protected string _instanceId;
		protected string _deviceName;
		protected string _backingName;
		public string ElementName
		{
			get
			{
				return this._elementName;
			}
			set
			{
				this._elementName = value;
			}
		}
		public string InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				this._instanceId = value;
			}
		}
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
		public string BackingName
		{
			get
			{
				return this._backingName;
			}
			set
			{
				this._backingName = value;
			}
		}
	}
}
