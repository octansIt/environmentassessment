namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpStackInfo : DynamicData
	{
		protected NetIpStackInfoNetToMedia[] _neighbor;
		protected NetIpStackInfoDefaultRouter[] _defaultRouter;
		public NetIpStackInfoNetToMedia[] Neighbor
		{
			get
			{
				return this._neighbor;
			}
			set
			{
				this._neighbor = value;
			}
		}
		public NetIpStackInfoDefaultRouter[] DefaultRouter
		{
			get
			{
				return this._defaultRouter;
			}
			set
			{
				this._defaultRouter = value;
			}
		}
	}
}
