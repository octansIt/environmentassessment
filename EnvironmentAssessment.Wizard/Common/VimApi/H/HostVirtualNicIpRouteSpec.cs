namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicIpRouteSpec : DynamicData
	{
		protected HostIpRouteConfig _ipRouteConfig;
		public HostIpRouteConfig IpRouteConfig
		{
			get
			{
				return this._ipRouteConfig;
			}
			set
			{
				this._ipRouteConfig = value;
			}
		}
	}
}
