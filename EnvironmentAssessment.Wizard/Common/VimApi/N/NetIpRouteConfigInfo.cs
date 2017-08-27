namespace EnvironmentAssessment.Common.VimApi
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
