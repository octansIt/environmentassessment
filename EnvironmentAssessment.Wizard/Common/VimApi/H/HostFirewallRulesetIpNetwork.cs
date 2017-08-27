namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFirewallRulesetIpNetwork : DynamicData
	{
		protected string _network;
		protected int _prefixLength;
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
	}
}
