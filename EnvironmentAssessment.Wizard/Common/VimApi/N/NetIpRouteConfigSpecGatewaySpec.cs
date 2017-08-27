namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpRouteConfigSpecGatewaySpec : DynamicData
	{
		protected string _ipAddress;
		protected string _device;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
	}
}
