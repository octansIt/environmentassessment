namespace EnvironmentAssessment.Common.VISoap
{
    public class NetIpRouteConfigInfo : DynamicData
	{
		protected NetIpRouteConfigInfoIpRoute[] _ipRoute;
		public NetIpRouteConfigInfoIpRoute[] IpRoute
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
