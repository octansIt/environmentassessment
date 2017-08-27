namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpConfigSpec : DynamicData
	{
		protected NetIpConfigSpecIpAddressSpec[] _ipAddress;
		protected NetDhcpConfigSpec _dhcp;
		protected bool? _autoConfigurationEnabled;
		public NetIpConfigSpecIpAddressSpec[] IpAddress
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
		public NetDhcpConfigSpec Dhcp
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
