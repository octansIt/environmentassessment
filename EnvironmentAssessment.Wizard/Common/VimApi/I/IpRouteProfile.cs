namespace EnvironmentAssessment.Common.VimApi
{
	public class IpRouteProfile : ApplyProfile
	{
		protected StaticRouteProfile[] _staticRoute;
		public StaticRouteProfile[] StaticRoute
		{
			get
			{
				return this._staticRoute;
			}
			set
			{
				this._staticRoute = value;
			}
		}
	}
}
