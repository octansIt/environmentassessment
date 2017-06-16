namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpRouteConfigSpec : HostIpRouteConfig
	{
		protected HostVirtualNicConnection _gatewayDeviceConnection;
		protected HostVirtualNicConnection _ipV6GatewayDeviceConnection;
		public HostVirtualNicConnection GatewayDeviceConnection
		{
			get
			{
				return this._gatewayDeviceConnection;
			}
			set
			{
				this._gatewayDeviceConnection = value;
			}
		}
		public HostVirtualNicConnection IpV6GatewayDeviceConnection
		{
			get
			{
				return this._ipV6GatewayDeviceConnection;
			}
			set
			{
				this._ipV6GatewayDeviceConnection = value;
			}
		}
	}
}
