namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaIPv6Properties : DynamicData
	{
		protected HostInternetScsiHbaIscsiIpv6Address[] _iscsiIpv6Address;
		protected bool? _ipv6DhcpConfigurationEnabled;
		protected bool? _ipv6LinkLocalAutoConfigurationEnabled;
		protected bool? _ipv6RouterAdvertisementConfigurationEnabled;
		protected string _ipv6DefaultGateway;
		public HostInternetScsiHbaIscsiIpv6Address[] IscsiIpv6Address
		{
			get
			{
				return this._iscsiIpv6Address;
			}
			set
			{
				this._iscsiIpv6Address = value;
			}
		}
		public bool? Ipv6DhcpConfigurationEnabled
		{
			get
			{
				return this._ipv6DhcpConfigurationEnabled;
			}
			set
			{
				this._ipv6DhcpConfigurationEnabled = value;
			}
		}
		public bool? Ipv6LinkLocalAutoConfigurationEnabled
		{
			get
			{
				return this._ipv6LinkLocalAutoConfigurationEnabled;
			}
			set
			{
				this._ipv6LinkLocalAutoConfigurationEnabled = value;
			}
		}
		public bool? Ipv6RouterAdvertisementConfigurationEnabled
		{
			get
			{
				return this._ipv6RouterAdvertisementConfigurationEnabled;
			}
			set
			{
				this._ipv6RouterAdvertisementConfigurationEnabled = value;
			}
		}
		public string Ipv6DefaultGateway
		{
			get
			{
				return this._ipv6DefaultGateway;
			}
			set
			{
				this._ipv6DefaultGateway = value;
			}
		}
	}
}
