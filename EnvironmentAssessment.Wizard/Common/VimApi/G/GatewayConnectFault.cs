namespace EnvironmentAssessment.Common.VimApi
{
	public class GatewayConnectFault : HostConnectFault
	{
		protected string _gatewayType;
		protected string _gatewayId;
		protected string _gatewayInfo;
		protected LocalizableMessage _details;
		public string GatewayType
		{
			get
			{
				return this._gatewayType;
			}
			set
			{
				this._gatewayType = value;
			}
		}
		public string GatewayId
		{
			get
			{
				return this._gatewayId;
			}
			set
			{
				this._gatewayId = value;
			}
		}
		public string GatewayInfo
		{
			get
			{
				return this._gatewayInfo;
			}
			set
			{
				this._gatewayInfo = value;
			}
		}
		public LocalizableMessage Details
		{
			get
			{
				return this._details;
			}
			set
			{
				this._details = value;
			}
		}
	}
}
