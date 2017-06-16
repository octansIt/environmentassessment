namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallRulesetIpList : DynamicData
	{
		protected string[] _ipAddress;
		protected HostFirewallRulesetIpNetwork[] _ipNetwork;
		protected bool _allIp;
		public string[] IpAddress
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
		public HostFirewallRulesetIpNetwork[] IpNetwork
		{
			get
			{
				return this._ipNetwork;
			}
			set
			{
				this._ipNetwork = value;
			}
		}
		public bool AllIp
		{
			get
			{
				return this._allIp;
			}
			set
			{
				this._allIp = value;
			}
		}
	}
}
