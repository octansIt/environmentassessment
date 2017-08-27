namespace EnvironmentAssessment.Common.VimApi
{
	public class HostGraphicsConfig : DynamicData
	{
		protected string _hostDefaultGraphicsType;
		protected string _sharedPassthruAssignmentPolicy;
		protected HostGraphicsConfigDeviceType[] _deviceType;
		public string HostDefaultGraphicsType
		{
			get
			{
				return this._hostDefaultGraphicsType;
			}
			set
			{
				this._hostDefaultGraphicsType = value;
			}
		}
		public string SharedPassthruAssignmentPolicy
		{
			get
			{
				return this._sharedPassthruAssignmentPolicy;
			}
			set
			{
				this._sharedPassthruAssignmentPolicy = value;
			}
		}
		public HostGraphicsConfigDeviceType[] DeviceType
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
