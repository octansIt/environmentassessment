namespace EnvironmentAssessment.Common.VISoap
{
    public class NetIpRouteConfigSpec : DynamicData
	{
		protected NetIpRouteConfigSpecIpRouteSpec[] _ipRoute;
		public NetIpRouteConfigSpecIpRouteSpec[] IpRoute
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
	}
}
