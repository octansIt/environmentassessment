namespace EnvironmentAssessment.Common.VISoap
{
    public class NetIpRouteConfigSpecIpRouteSpec : DynamicData
	{
		protected string _network;
		protected int _prefixLength;
		protected NetIpRouteConfigSpecGatewaySpec _gateway;
		protected string _operation;
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
		public NetIpRouteConfigSpecGatewaySpec Gateway
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
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
