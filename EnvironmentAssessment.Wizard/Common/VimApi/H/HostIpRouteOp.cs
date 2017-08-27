namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpRouteOp : DynamicData
	{
		protected string _changeOperation;
		protected HostIpRouteEntry _route;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
			}
		}
		public HostIpRouteEntry Route
		{
			get
			{
				return this._route;
			}
			set
			{
				this._route = value;
			}
		}
	}
}
