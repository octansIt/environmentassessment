namespace EnvironmentAssessment.Common.VISoap
{
    public class NetDhcpConfigSpec : DynamicData
	{
		protected NetDhcpConfigSpecDhcpOptionsSpec _ipv6;
		protected NetDhcpConfigSpecDhcpOptionsSpec _ipv4;
		public NetDhcpConfigSpecDhcpOptionsSpec Ipv6
		{
			get
			{
				return this._ipv6;
			}
			set
			{
				this._ipv6 = value;
			}
		}
		public NetDhcpConfigSpecDhcpOptionsSpec Ipv4
		{
			get
			{
				return this._ipv4;
			}
			set
			{
				this._ipv4 = value;
			}
		}
	}
}
