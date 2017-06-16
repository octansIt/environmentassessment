namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpRouteConfig : DynamicData
	{
		protected string _defaultGateway;
		protected string _gatewayDevice;
		protected string _ipV6DefaultGateway;
		protected string _ipV6GatewayDevice;
		public string DefaultGateway
		{
			get
			{
				return this._defaultGateway;
			}
			set
			{
				this._defaultGateway = value;
			}
		}
		public string GatewayDevice
		{
			get
			{
				return this._gatewayDevice;
			}
			set
			{
				this._gatewayDevice = value;
			}
		}
		public string IpV6DefaultGateway
		{
			get
			{
				return this._ipV6DefaultGateway;
			}
			set
			{
				this._ipV6DefaultGateway = value;
			}
		}
		public string IpV6GatewayDevice
		{
			get
			{
				return this._ipV6GatewayDevice;
			}
			set
			{
				this._ipV6GatewayDevice = value;
			}
		}
	}
}
