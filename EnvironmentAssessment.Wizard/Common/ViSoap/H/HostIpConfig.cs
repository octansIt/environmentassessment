namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpConfig : DynamicData
	{
		protected bool _dhcp;
		protected string _ipAddress;
		protected string _subnetMask;
		protected HostIpConfigIpV6AddressConfiguration _ipV6Config;
		public bool Dhcp
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
		public string IpAddress
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
		public HostIpConfigIpV6AddressConfiguration IpV6Config
		{
			get
			{
				return this._ipV6Config;
			}
			set
			{
				this._ipV6Config = value;
			}
		}
	}
}
