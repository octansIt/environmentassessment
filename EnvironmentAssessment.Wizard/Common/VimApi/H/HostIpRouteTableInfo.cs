namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpRouteTableInfo : DynamicData
	{
		protected HostIpRouteEntry[] _ipRoute;
		protected HostIpRouteEntry[] _ipv6Route;
		public HostIpRouteEntry[] IpRoute
		{
			get
			{
				return this._ipRoute;
			}
			set
			{
				this._ipRoute = value;
			}
		}
		public HostIpRouteEntry[] Ipv6Route
		{
			get
			{
				return this._ipv6Route;
			}
			set
			{
				this._ipv6Route = value;
			}
		}
	}
}
