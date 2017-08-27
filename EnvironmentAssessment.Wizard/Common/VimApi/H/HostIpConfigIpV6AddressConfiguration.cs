namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpConfigIpV6AddressConfiguration : DynamicData
	{
		protected HostIpConfigIpV6Address[] _ipV6Address;
		protected bool? _autoConfigurationEnabled;
		protected bool? _dhcpV6Enabled;
		public HostIpConfigIpV6Address[] IpV6Address
		{
			get
			{
				return this._ipV6Address;
			}
			set
			{
				this._ipV6Address = value;
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
		public bool? DhcpV6Enabled
		{
			get
			{
				return this._dhcpV6Enabled;
			}
			set
			{
				this._dhcpV6Enabled = value;
			}
		}
	}
}
