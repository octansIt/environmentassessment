namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnsupportedSubType : OvfUnsupportedPackage
	{
		protected string _elementName;
		protected string _instanceId;
		protected int _deviceType;
		protected string _deviceSubType;
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
		public int DeviceType
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
		public string DeviceSubType
		{
			get
			{
				return this._deviceSubType;
			}
			set
			{
				this._deviceSubType = value;
			}
		}
	}
}
