namespace EnvironmentAssessment.Common.VISoap
{
    public class NetIpConfigInfo : DynamicData
	{
		protected NetIpConfigInfoIpAddress[] _ipAddress;
		protected NetDhcpConfigInfo _dhcp;
		protected bool? _autoConfigurationEnabled;
		public NetIpConfigInfoIpAddress[] IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public NetDhcpConfigInfo Dhcp
		{
			get
			{
				return this._dhcp;
			}
			set
			{
				this._dhcp = value;
			}
		}
		public bool? AutoConfigurationEnabled
		{
			get
			{
				return this._autoConfigurationEnabled;
			}
			set
			{
				this._autoConfigurationEnabled = value;
			}
		}
	}
}
