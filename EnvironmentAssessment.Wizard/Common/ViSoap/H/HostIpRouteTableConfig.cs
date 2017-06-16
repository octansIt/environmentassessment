namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpRouteTableConfig : DynamicData
	{
		protected HostIpRouteOp[] _ipRoute;
		protected HostIpRouteOp[] _ipv6Route;
		public HostIpRouteOp[] IpRoute
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
		public HostIpRouteOp[] Ipv6Route
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
