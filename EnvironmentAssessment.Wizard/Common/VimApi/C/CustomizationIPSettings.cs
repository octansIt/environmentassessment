namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationIPSettings : DynamicData
	{
		protected CustomizationIpGenerator _ip;
		protected string _subnetMask;
		protected string[] _gateway;
		protected CustomizationIPSettingsIpV6AddressSpec _ipV6Spec;
		protected string[] _dnsServerList;
		protected string _dnsDomain;
		protected string _primaryWINS;
		protected string _secondaryWINS;
		protected CustomizationNetBIOSMode? _netBIOS;
		public CustomizationIpGenerator Ip
		{
			get
			{
				return this._ip;
			}
			set
			{
				this._ip = value;
			}
		}
		public string SubnetMask
		{
			get
			{
				return this._subnetMask;
			}
			set
			{
				this._subnetMask = value;
			}
		}
		public string[] Gateway
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
		public CustomizationIPSettingsIpV6AddressSpec IpV6Spec
		{
			get
			{
				return this._ipV6Spec;
			}
			set
			{
				this._ipV6Spec = value;
			}
		}
		public string[] DnsServerList
		{
			get
			{
				return this._dnsServerList;
			}
			set
			{
				this._dnsServerList = value;
			}
		}
		public string DnsDomain
		{
			get
			{
				return this._dnsDomain;
			}
			set
			{
				this._dnsDomain = value;
			}
		}
		public string PrimaryWINS
		{
			get
			{
				return this._primaryWINS;
			}
			set
			{
				this._primaryWINS = value;
			}
		}
		public string SecondaryWINS
		{
			get
			{
				return this._secondaryWINS;
			}
			set
			{
				this._secondaryWINS = value;
			}
		}
		public CustomizationNetBIOSMode? NetBIOS
		{
			get
			{
				return this._netBIOS;
			}
			set
			{
				this._netBIOS = value;
			}
		}
	}
}
