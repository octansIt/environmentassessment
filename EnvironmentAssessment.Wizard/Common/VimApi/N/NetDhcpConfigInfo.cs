namespace EnvironmentAssessment.Common.VimApi
{
	public class NetDhcpConfigInfo : DynamicData
	{
		protected NetDhcpConfigInfoDhcpOptions _ipv6;
		protected NetDhcpConfigInfoDhcpOptions _ipv4;
		public NetDhcpConfigInfoDhcpOptions Ipv6
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
		public NetDhcpConfigInfoDhcpOptions Ipv4
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
