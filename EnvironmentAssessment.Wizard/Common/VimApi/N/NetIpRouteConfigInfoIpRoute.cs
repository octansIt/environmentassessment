namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpRouteConfigInfoIpRoute : DynamicData
	{
		protected string _network;
		protected int _prefixLength;
		protected NetIpRouteConfigInfoGateway _gateway;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public int PrefixLength
		{
			get
			{
				return this._prefixLength;
			}
			set
			{
				this._prefixLength = value;
			}
		}
		public NetIpRouteConfigInfoGateway Gateway
		{
			get
			{
				return this._gateway;
			}
			set
			{
				this._gateway = value;
			}
		}
	}
}
